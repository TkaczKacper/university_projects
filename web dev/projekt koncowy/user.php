<?php session_start(); ?>
<!DOCTYPE html>
<html>
  <head>
    <title>Hotel bozy</title>
    <link rel="stylesheet" href="styleuser.css">    
    <meta charset='UTF-8' />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    
  </head> 
  <body>
    <?php require_once('colors.php') ?>
    <div class="nav_bar">
      <div id="logged">
        <?php
          
          if ($_SESSION['zalogowany_recepcjonista']) {
            echo "receptionist panel";
          } else if($_SESSION['zalogowany_cleaner']) {
            echo "cleaner panel";
          }
          if (isset($_POST["wyloguj"])) {
            setcookie("zalogowany_recepcjonista", 0);
            setcookie("zalogowany_cleaner", 0);
            $_SESSION['zalogowany_recepcjonista'] = 0;
            $_SESSION['zalogowany_cleaner'] = 0;
            header("Location:index.php");
          }
        ?>       
      </div>
      <form method="post">
        <input type="submit" value="wyloguj" name="wyloguj">
      </form>
    </div>
    
    <div class="user"></div>

    <div class="content">
      <div id="hotelplan">
        <!--<figure>
        <a><img src="https://conceptdraw.com/a490c4/p1/preview/640/pict--floor-plan-mini-hotel-floor-plan"></a>
        </figure>-->
        <div id="row1">
          <div id="room1" class="rooms" class="not_avaiable">1</div>
          <div id="room2" class="rooms" class="not_avaiable">2</div>
          <div id="room3" class="rooms">3</div>
          <div id="room4" class="rooms">4</div>
          <div id="room5" class="rooms">5</div>
          
        </div>
        <div id="row2">
          <div id="room6" class="rooms">6</div>
          <div id="room7" class="rooms">7</div>
          <div id="room8" class="rooms">8</div>
          <div id="room9" class="rooms">9</div>
          <div id="room10" class="rooms">10</div>
        </div>
        <div id="task_to_do">
          <?php 
            if ($_SESSION['zalogowany_recepcjonista']) {
              require_once('tasks.php');
            }            
          ?>
        </div>
      </div>

      <div id="room_table">
        <table>
          <tr>
            <?php
              if (isset($_SESSION['msg'])) {
                $message = $_SESSION['msg'];
                unset($_SESSION['msg']);
                echo $message;
              }
            ?>
          </tr>
          <tr>
            <div id="room_info" style="display: none;">
              
            </div>
          </tr>
          <tr>
            <div class="form_container" style="display: none;">
            </div>
          </tr>
          <tr>
            <div id="cleaner_form" style="display: none;">
            
            </div>
          </tr>
      </div>
    </div>
    <script src="code.js" type="text/javascript"></script>
  </body>
</html>