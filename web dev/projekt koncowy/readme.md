# System obsługi hotelu

System obsługi hotelowej który za pomocą dwóch oddzielnych interfejsów użytkowanika: cleanera oraz recepcjonisty, umożliwia w sposób zoptymalizowany zarządzanie hotelem.

## Konta użytkowników

Uprawnienia i funkcjonalności są przyznawane z zależności od zalogowanego użytkownika. Możliwe jest zalogowanie się na konto:

- cleaner, z hasłem dostępowym: cleaner
- receptionist, z hasłem dostępowym: receptionist

## Instrukcja dołączenia bazy danych w _phpmyadmin_
W celu zalogowania się na konta użytkowników w aplikacji, konieczne jest utworzenie kont uzytkowników w phpmyadmin. 
Aby to zrobić należy utworzyć konta według następujących parametrów:

- dla receptionist:
     -  _user name:_ receptionist
    - _host name:_ localhost
    - _password:_ eF0TJW@24rA0fw[E


- dla cleanera:
    - _user name:_ cleaner
    - _host name:_ cleaner
    - _password:_ Fmu3fx8xm7e5PRBK

Następnie w celu nadania tym użytkownikom uprawnień konieczne jest zaimportowanie w oprogramowaniu _phpmyadmin_ pliku **users_to_sql.txt**.

Następnie trzeba dodać bazę danych którą ci użytkownicy będą obsługiwać. W tym celu należy zaimportować plik **hotel.sql**.


