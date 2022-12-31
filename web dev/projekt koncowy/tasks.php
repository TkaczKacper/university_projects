<?php
    $link = mysqli_connect("localhost", "root", "", "hotel");

    $sql = "SELECT * FROM pokoje";
    $result = $link->query($sql);
   
    $numer = 1;
    $datetime = date_create()->format('Y-m-d H:i:s');
    $checkin = "";
    $checkout = "";

    if (!$link) 
    {
        printf("Connect failed: %s\n", mysqli_connect_error()); exit();
    }

    foreach ($result as $v) {
        if ($v["RESERVATION"] == 1) {            
            if ($datetime > $v["CHECK_OUT"]) {
                $checkout .= "$numer, ";
            }
        }
        $numer++;
    }

    echo 'Pokoje do wymeldowania: ' . $checkout;

    $link->close();
?>