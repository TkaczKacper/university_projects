<?php include('server.php') ?>
<!DOCTYPE html>
<html>
	<head>
		<link rel="stylesheet" href="style.css">
		<title>Log in</title>
		<meta charset='UTF-8' />
	</head>

	<body>
		<?php include('errors.php'); 

			if ($_SESSION['zalogowany_recepcjonista']) {
				header("Location:user.php");
			} else if($_SESSION['zalogowany_cleaner']) {
				header("Location:user.php");
			}

		?>
		
		<div id="login_form">
			<form method='POST' action='index.php'>
				<p><br> <input type="text" name="login" placeholder="login"> </p>
				<p><br> <input type="password" name="password" placeholder="password"> </p>
				<button id="zaloguj" class="zaloguj" type="sumbit" name="zaloguj"> Log in </button>
				</br>
			</form>
		</div>
	</body>
</html>
