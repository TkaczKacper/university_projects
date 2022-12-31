<?php
    $link = mysqli_connect("localhost", "cleaner", "Fmu3fx8xm7e5PRBK", "hotel");

    $current_room = $_COOKIE["current_room"];

    if (!$link) 
    {
        printf("Connect failed: %s\n", mysqli_connect_error()); exit();
    }

    $sql = "UPDATE pokoje SET IF_CLEAN='1' WHERE NUMBER=$current_room";
    $stmt = $link->prepare($sql);
    $result = $stmt->execute();
    
    $stmt->close();
    $link->close();

    header('Location: user.php');
?>