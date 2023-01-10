from django.db import models
from django.contrib.auth.models import AbstractUser

# Create your models here.
class User(AbstractUser):
          pass

class Weather(models.Model):
          condition = models.CharField(blank=True, null=True, max_length=20)
          last_updated = models.CharField(blank=True, max_length=20)
          wind_kph = models.DecimalField(max_digits=5, decimal_places=1, blank=True)
          wind_dir = models.CharField(blank=True, max_length=3)
          humidity = models.IntegerField(blank=True)
          gusts_kph = models.DecimalField(max_digits=5, decimal_places=1, blank=True)
          air_quality_index = models.IntegerField(blank=True)
          temperature = models.DecimalField(max_digits=2, decimal_places=1, blank=True)
          precipation = models.DecimalField(max_digits=3, decimal_places=1, blank=True)
          cloud = models.IntegerField(blank=True)
          mail_sent = models.BooleanField(default=False)
