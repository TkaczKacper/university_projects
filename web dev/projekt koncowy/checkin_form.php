<?php
    $link = mysqli_connect("localhost", "receptionist", "eF0TJW@24rA0fw[E", "hotel");

    $sql = "SELECT * FROM pokoje";
    $result = $link->query($sql);

    $current_room = $_COOKIE["current_room"];

    if (!$link) 
    {
        printf("Connect failed: %s\n", mysqli_connect_error()); exit();
    }

    

    print<<<KONIEC
    <html>
        <head></head>
        <body>
            <form action="checkin_form_redirect.php" method="POST">
                <div id="form_container">
                <div id="room_nb"> numer pokoju: $current_room <br> <br> </div>
                <div class="form_fields">
                wprowadź imię i nazwisko gościa <input type="text" name="guest_name"><br>
                </div>
                <div class="form_fields">
                data zakwaterowania <input type="datetime-local" name="check_in"><br>
                </div>
                <div class="form_fields">
                data wykwaterowania<input type="datetime-local" name="check_out"><br>
                </div>
                <div id="inputs">
                <input type="submit" value="zakwateruj" >
                <input type="reset" value="wyczysc">
                </div>
                </div>
            </form>
            
        </body>
    </html>

    KONIEC;
?>