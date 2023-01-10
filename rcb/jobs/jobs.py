from django.conf import settings
import requests, json
from django.utils import timezone
from decimal import Decimal

from main.models import Weather

def weather():
          full_url = f'http://api.weatherapi.com/v1/current.json?key={settings.API_KEY}&q=Cracow&aqi=yes'

          r = requests.get(full_url)
          if r.status_code == 200:
                    result = r.json()["current"]

                    if result["last_updated"] == Weather.objects.all().last().last_updated:
                              print("database not updated")
                    else:
                              weather = Weather()
                              weather.condition = result["condition"]["text"]
                              weather.last_updated = result["last_updated"]
                              weather.wind_dir = result["wind_dir"]
                              weather.wind_kph = result["wind_kph"]
                              weather.humidity = Decimal(result["humidity"])
                              weather.gusts_kph = Decimal(result["gust_kph"])
                              weather.temperature = Decimal(result["temp_c"])
                              weather.precipation = Decimal(result["precip_mm"])
                              weather.cloud = result["cloud"]
                              weather.air_quality_index = 4
                              weather.save()
                              print("upadted")
