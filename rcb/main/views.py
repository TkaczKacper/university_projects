from django.shortcuts import render
from django.contrib.auth import authenticate, login, logout
from django.http import HttpResponseRedirect, HttpResponse
from django.urls import reverse
from django.db import IntegrityError
from django.core.mail import EmailMultiAlternatives
from django.conf import settings
from django.utils import timezone, dateformat

import requests

from .models import User, Weather
# Create your views here.

def air_quality(i):
          air_q = {
                    1: "Dobry",
                    2: "Umiarkowany",
                    3: "Niezdrowy dla wrażliwych",
                    4: "Niezdrowy",
                    5: "Bardzo niezdrowy",
                    6: "Niebiezpieczny",
          }
          return air_q[i]

def weather():
          data = Weather.objects.last()
          weather = []
          weather.append(f"{data.condition}, Temperatura: {data.temperature}C")
          weather.append(f"Wiatr: {data.wind_kph}km/h, kierunek: {data.wind_dir}")
          weather.append(f"Wskaznik jakosci powietrza: {air_quality(data.air_quality_index)}")
          weather.append(f"Wilgotność: {data.humidity}%")
          weather_update = f"Ostatnia aktualizacja: {data.last_updated}"
          return [weather, weather_update]

def alerts():
          data = Weather.objects.last()
          message = ""
          message_more = ""
          alerts = []
          if data.air_quality_index > 2:
                    alerts.append(f'{air_quality(data.air_quality_index)} wskaźnik jakości powietrza, unikaj aktywności fizycznej na zewnątrz.')
                    message = f'<p><strong>UWAGA!</strong> Niska jakość powietrza.</p><br><p>Wskaźnik jakości powietrza {air_quality(data.air_quality_index).lower()}, staraj się unikać aktywności fizycznej na zewnątrz.</p><br><p>Dziękujemy za korzystanie z powiadomień RCB Kraków, życzymy miłego dnia!</p>'
                    message_more = '<li>Niska jakość powietrza.</li>'
          if data.temperature > -10:
                    alerts.append('Niska temperatura na zewnątrz, rozważ pozostanie w domu, uważaj na przymarznięcia.')
                    message = f'<p><strong>Uwaga!</strong> Niska temperatura na zewnątrz, rozważ pozostanie w domu, uważaj na przymarznięcia</p><br><p>Dziękujemy za korzystanie z powiadomień RCB Kraków, życzymy miłego dnia!</p>'
                    message_more += '<li>Niska temperatura.</li>'
          if data.temperature > 30:
                    alerts.append('Niebezpiecznie wysoka temperatura na zewnątrz, staraj się unikać dłuższej ekspozycji na słońcu, dbaj o odpowiednie nawodnienie.')
                    message = f'<p><strong>Uwaga!</strong> Niebezpiecznie wysoka temperatura na zewnątrz, staraj się unikać dłuższej ekspozycji na słońcu, dbaj o odpowiednie nawodnienie.</p><br><p>Dziękujemy za korzystanie z powiadomień RCB Kraków, życzymy miłego dnia!</p>'
                    message_more += '<li>Wysoka temperatura.</li>' 
          if data.wind_kph > 80:
                    alerts.append('Uwaga! silny wiatr, zabezpiecz rzeczy, które może porwać wiatr.')
                    message = f'<p><strong>Uwaga!</strong> silny wiatr, zabezpiecz rzeczy, które może porwać wiatr.</p><br><p>Dziękujemy za korzystanie z powiadomień RCB Kraków, życzymy miłego dnia!</p>'
                    message_more += '<li>Silny wiatr.</li>'
          if data.gusts_kph > 80:
                    alerts.append('Uwaga! możliwy porywisty wiatr, zabezpiecz rzeczy które mogą zostać zniszczone.')
                    message = f'<p><strong>Uwaga!</strong> możliwe silne porywy wiatru, zabezpiecz rzeczy które moga zostać porwane lub zniszczone.</p><br><p>Dziękujemy za korzystanie z powiadomień RCB Kraków, życzymy miłego dnia!</p>'
                    message_more += '<li>Silne porywy wiatru.</li>'

          if len(alerts) > 1:
                    message_html = f'<p><strong>Uwaga!</strong> szykuje się nieprzyjemny dzień.</p><br><p>Alerty na dziś:</p><ul>{message_more}</ul><br><p>Jeżeli to możliwe, pozostań dziś w domu.</p><br><p>Dziękujemy za korzystanie z powiadomień RCB Kraków, życzymy miłego dnia!</p>'
          else:
                    message_html = message

          return [alerts, message_html]

def index(request):
          return render(request, 'main/index.html', {
                    "threats": alerts()[0],
                    "weather": weather()[0],
                    "last_update":  weather()[1]
          })

def login_view(request):
          if request.method == "POST":

                    #try to find user in database
                    username = request.POST["username"]
                    password = request.POST["password"]
                    user = authenticate(request, username=username, password=password)

                    if user is not None:
                              login(request, user)
                              return HttpResponseRedirect(reverse('index'))
                    else:
                              return render(request, 'main/login.html', {
                              "message": "Nieprawidlowy login i/lub haslo."
                              }) 

          return render(request, 'main/login.html')


def logout_view(request):
          logout(request)
          return HttpResponseRedirect(reverse("index"))


def register(request):
          if request.method == "POST":
                    username = request.POST["username"]
                    email = request.POST["email"]

                    password = request.POST["password"]
                    confirmation = request.POST["confirmation"]

                    if password != confirmation:
                              return render(request, 'main/register.html', {
                              "message": "Hasla musza byc takie same."
                              })

                    try:
                              user = User.objects.create_user(username, email, password)
                              user.save()
                    except IntegrityError:
                              return render(request, 'main/register.html', {
                              "message": "Nazwa uzytkownika jest juz zajeta."
                              })

                    login(request, user)
                    return HttpResponseRedirect(reverse('index'))
          return render(request, 'main/register.html')


def email():
          print("email sent")
          data = Weather.objects.last()
          users = User.objects.all().distinct()
          recipient_list = []
          for user in users:
               recipient_list.append(user.email)
          subject = f'Alert for {data.last_updated}'

          from_email = settings.EMAIL_HOST_USER
          text_context = f"{air_quality(data.air_quality_index)} wskaznik jakosci powietrza, unikaj aktywnosci fizycznej na zewnatrz."

          html_content = alerts()[1]
          msg = EmailMultiAlternatives(subject, text_context, from_email, recipient_list)
          msg.attach_alternative(html_content, "text/html")
          msg.send()
