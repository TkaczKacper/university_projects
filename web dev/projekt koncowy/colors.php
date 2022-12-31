<?php
    $link = mysqli_connect("localhost", "root", "", "hotel");

    $sql = "SELECT * FROM pokoje";
    $result = $link->query($sql);
   
    $numer = 1;
    $datetime = date_create()->format('Y-m-d H:i:s');

    if (!$link) 
    {
        printf("Connect failed: %s\n", mysqli_connect_error()); exit();
    }

    foreach ($result as $v) {
        if ($v["RESERVATION"] == 0 && $v["IF_CLEAN"] == 1) {
            setcookie("room.$numer.color", "green");
        } else if ($datetime < $v["CHECK_IN"]) {
            setcookie("room.$numer.color", "#1D4625");
        } else if ($v["IF_CLEAN"] == 0 && $v["RESERVATION"] == 0) {
            setcookie("room.$numer.color", "orange");
        } else if ($datetime > $v["CHECK_OUT"]) {
            setcookie("room.$numer.color", "#8B0000");
        } else {
            setcookie("room.$numer.color", "red");
        }
        $numer++;
    }

    $link->close();
?>