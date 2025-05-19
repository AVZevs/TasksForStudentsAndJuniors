<?php 
  session_start();
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Поздравляем! Вы вошли в админку! Задача решена!</title>
  <link rel="stylesheet" href="styles.css">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/>  
  <link rel="icon" type="image/png" sizes="32x32" href="favicon-32x32.png">
  <link rel="icon" type="image/png" sizes="16x16" href="favicon-16x16.png">
  <link rel="shortcut icon" href="favicon.ico">  
</head>
<body style="display: flex; justify-content: center; align-items: center; height: 100vh">
  <div class="flag">
    <?php 
      if(isset($_SESSION['flag'])) {
        echo $_SESSION['flag'];
      } else {
        echo "ERROR 401 - Unauthorized";
      }
    ?>
  </div>
</body>
</html>