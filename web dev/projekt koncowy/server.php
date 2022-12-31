<?php session_start();

  $username = "";
  $errors = array();

  $sql = mysqli_connect('localhost', 'root', '', 'hotel');

  if (isset($_POST['zaloguj'])) {

    $username = mysqli_real_escape_string($sql, $_POST['login']);
    $password = mysqli_real_escape_string($sql, $_POST['password']);

    if (empty($username)) {
        array_push($errors, "Podaj nazwę użytkownika.");
    }
    if (empty($password)) {
        array_push($errors, "Podaj hasło.");
    }
    if (count($errors) == 0) {
        $password = md5($password);
        $data = "SELECT * FROM users WHERE username='$username' AND password='$password'";
        $results = mysqli_query($sql, $data);
        if (mysqli_num_rows($results) == 1) {
          $_SESSION['username'] = $username;
          if ($username == "cleaner") {
            $_SESSION['zalogowany_cleaner'] = 1;
            setcookie("zalogowany_cleaner", 1);
          } else{
            setcookie("zalogowany_recepcjonista", 1);
            $_SESSION['zalogowany_recepcjonista'] = 1;
          }
          header('location: user.php');
        } else {
            array_push($errors, "Nieprawidłowy login i/lub hasło.");
        }
    }
  }
?>