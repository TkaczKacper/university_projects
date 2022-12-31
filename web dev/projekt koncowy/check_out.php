<?php
    $link = mysqli_connect("localhost", "receptionist", "eF0TJW@24rA0fw[E", "hotel");

    $sql = "SELECT * FROM pokoje";
    $result = $link->query($sql);

    $current_room = $_COOKIE["current_room"];

    if (!$link) 
    {
        printf("Connect failed: %s\n", mysqli_connect_error()); exit();
    }

    $sql = "UPDATE pokoje SET RESERVATION='0', GUEST_NAME=null, CHECK_IN=null, CHECK_OUT=null, IF_CLEAN='0' WHERE NUMBER=$current_room";
    $stmt = $link->prepare($sql);
    $result = $stmt->execute();
    
    $stmt->close();
    $link->close();

    header('Location: user.php');
?>