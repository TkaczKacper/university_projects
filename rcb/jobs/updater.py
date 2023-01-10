from apscheduler.schedulers.background import BackgroundScheduler

from .jobs import weather
from main.views import email


def start():
          scheduler = BackgroundScheduler()
          scheduler.add_job(weather, 'interval', minutes=3)
          scheduler.add_job(email, 'cron', hour='8, 9, 10', minute='7')
          try:
                    scheduler.start()
          except SystemExit:
                    scheduler.shutdown()