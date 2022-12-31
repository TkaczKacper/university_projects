<?php
    session_start();

    $link = mysqli_connect("localhost", "receptionist", "eF0TJW@24rA0fw[E", "hotel");
    
    if (!$link) 
    {
        printf("Connect failed: %s\n", mysqli_connect_error()); exit();
    }
    
    $current_room = $_COOKIE["current_room"];
    $guest_name = $_POST['guest_name'];
    $check_in = $_POST['check_in'];
    $check_out = $_POST['check_out'];
    
    if (isset($_POST['guest_name'], $_POST['check_in'], $_POST['check_out']) && $check_in < $check_out) {
        $sql = "UPDATE pokoje SET RESERVATION='1', GUEST_NAME='$guest_name', CHECK_IN='$check_in', CHECK_OUT='$check_out' WHERE NUMBER=$current_room";

        $stmt = $link->prepare($sql);
        $result = $stmt->execute();
        if (!$result) {
            printf("Query failed: %s\n", mysqli_error($link));
            
        }
        $stmt->close();
    } else if ($check_in > $check_out) {
        $_SESSION['msg']="Data wymeldowania nie może być poźniejsza niż data zakwaterowania.";
    } else {
        $_SESSION['msg']="błąd";
    }


    header("Location:user.php");
    
    
    mysqli_close($link);
?>
