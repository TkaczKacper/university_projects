# Generated by Django 4.1.4 on 2023-01-09 20:05

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0004_alter_weather_last_updated'),
    ]

    operations = [
        migrations.AddField(
            model_name='weather',
            name='condition',
            field=models.CharField(blank=True, max_length=20, null=True),
        ),
    ]
