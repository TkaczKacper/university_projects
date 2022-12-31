<?php 
    $link = mysqli_connect("localhost", "cleaner", "Fmu3fx8xm7e5PRBK", "hotel");
    $current_room = $_COOKIE["current_room"];

    $sql = "SELECT IF_CLEAN, RESERVATION FROM pokoje WHERE NUMBER=$current_room";
    $result = $link->query($sql);

    foreach ($result as $v) {
        if ($v["IF_CLEAN"] == 1 && $v["RESERVATION"] == 0) {
            echo "<div class=\"container\" id=\"requirement\"> <div id=\"room_cleaner_get\">numer pokoju: ".$current_room."</div> <br> pokój posprzątany <br> nie ma tu co robić <br> <br></div>";
        
        } elseif ($v["RESERVATION"] == 1) {
            echo "<div class=\"container\" id=\"requirement\"> <div id=\"room_cleaner_get\">numer pokoju: ".$current_room."</div><br> Pokój zajęty. Lepiej nie przeszkadzać gościom. <br> <br></div>";
        
        } else {
            echo "<div class=\"container\" id=\"requirement\">   <div id=\"room_cleaner_get\">numer pokoju: ".$current_room."</div> <br> Pokój do posprzątania. <br>
            <br>Jeśli został posprzątany: <br> <a class=\"button\" href=\"cleaning_done.php\">Kliknij</a>";
        }
    }
    
    $result->free();
    $link->close();

?>
<script src="code.js" type="text/javascript"></script>