from django.contrib import admin

from .models import Weather, User
# Register your models here.

admin.site.register(User)
admin.site.register(Weather)