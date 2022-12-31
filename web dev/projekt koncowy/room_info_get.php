<?php 
    $link = mysqli_connect("localhost", "receptionist", "eF0TJW@24rA0fw[E", "hotel");
    $current_room = $_COOKIE["current_room"];

    $timezone = date_default_timezone_get(); 
    $datetime = date_create()->format('Y-m-d H:i:s');

    $sql = "SELECT * FROM pokoje WHERE NUMBER=$current_room";
    $result = $link->query($sql);

    foreach ($result as $v) {
        if ($v["RESERVATION"] == 1) {
            echo "<div class=\"container\"><div id=\"room_nb_get\">numer pokoju: ".$v["NUMBER"]."</div>"
                    .
                 "<br>"."<div class=\"form_fields\">imię i nazwisko: <br><span> ".$v["GUEST_NAME"]." </span></div>"
                    .
                "  <div class=\"form_fields\"> data zakwaterowania: <br> <span>".$v["CHECK_IN"]."</span></div>"
                    .
                "  <div class=\"form_fields\"> data wymeldowania: <br> <span>".$v["CHECK_OUT"]."</span><br> </div>"; 
            
            if($datetime > $v["CHECK_OUT"]){
                echo '<a class="button" id="check_out" href="check_out.php">Wymelduj gościa.</a><br> </div>';
            }
            if ($datetime < $v["CHECK_IN"]) {
                echo '<a class="button" id="check_out" href="check_out.php">Anuluj pobyt.</a><br> </div>';
            }
        }
        if ($v["IF_CLEAN"] == 0) {
            echo "<div class=\"container\" id=\"requirement\"> <br> pokój wymaga sprzątania <br> nie jest możliwe zakwaterowanie gościa <br> <br></div>";
        }
        if ($v["RESERVATION"] == 0 && $v["IF_CLEAN"]==1) {
            echo "<div class=\"container\"><div id=\"room_nb_get\">numer pokoju: ".$v["NUMBER"]."</div>".
            "<div class=\"form_fields\" class=\"content\"><span> Pokój wolny. </span> </div><br>"."
            <a class=\"button\" class=\"content\" id=\"add\">Zakwateruj gościa.</a><br>
            <br> </div>
            ";
        }
    }
    
    $result->free();
    $link->close();
?>

<script src="code.js" type="text/javascript"></script>