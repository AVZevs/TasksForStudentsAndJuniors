<?php 
session_start();

$valid_username_admin = "admin";
$valid_password_admin = "admin";

$valid_username_one = "JorikTester";
$valid_password_one = "%Hug45guestIn^";

$valid_username_two = "TrustedAdmin";
$valid_password_two = "&Son0fF%teSSter";

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (isset($_POST['username']) && isset($_POST['password'])) {
        $username = $_POST['username'];
        $password = $_POST['password'];

        if ($username === $valid_username_admin && $password === $valid_password_admin) {
			echo '<script type="text/javascript"> window.onload = function() { alert("admin:admin ? Серьезно ?! Это было бы очень просто! Поищите другие учетные данные. Они точно где-то здесь есть."); }</script>';
			
        } else {
			if ($username === $valid_username_one && $password === $valid_password_one || $username === $valid_username_two && $password === 		$valid_password_two) {			
				$_SESSION['authenticated'] = true; 
				header('Location: index.php'); 
				exit();
			}
			else {
				$error = "Неверный логин или пароль.";
			}	
        }
    } elseif (isset($_POST['num1']) && isset($_POST['num2']) && isset($_POST['num3']) && isset($_POST['num4'])) {
        if ($_SESSION['authenticated'] && $_POST['num1'] == "1" && $_POST['num2'] == "9" && $_POST['num3'] == "7" && $_POST['num4'] == "3") {
            $_SESSION['flag'] = "Поздравляем! Вы вошли в админку! Задача решена!";
            header('Location: admin.php');
            exit(); 
        } else {
            $error = "Неверный пин-код.";
        }
    }
}
?>

<!DOCTYPE html>
<!-- Created By Zevs from QA Service Lab -->
<html lang="en" dir="ltr">
   <head>
      <meta charset="utf-8">
      <title>Ваша задача залогиниться на сайте и войти в админку...</title>
      <link rel="stylesheet" href="styles.css">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/>  
	  <link rel="icon" type="image/png" sizes="32x32" href="favicon-32x32.png">
	  <link rel="icon" type="image/png" sizes="16x16" href="favicon-16x16.png">
	  <link rel="shortcut icon" href="favicon.ico">
   </head>
   <body>
	  <!-- div class="login-form"
	  the real login of the administrator - TrustedAdmin -->
  	  
	  <div class="login-form">
		<?php if (!isset($_SESSION['authenticated'])): ?>
	  
         <div class="text">Вход на сайт</div>
		 
		 <div>
         <form method="post">
            <div class="field">
               <div class="fas fa-envelope"></div>
               <input type="text" name="username" placeholder="Введите логин" maxlength="15" required />
            </div>
            <div class="field">
               <div class="fas fa-lock"></div>
			   <!-- Наверняка Вы уже нашли валидный пароль, верно? А может быть он просто не влезает в поле ввода пароля? ... -->
               <input type="password" name="password" placeholder="Введите пароль" maxlength="10" required />
            </div>
            <button>Войти</button>
            <div class="link">
               Не знаю что делать...
               <a href="#" id="showModal">Подскажи, плиз...</a>
            </div>			
         </form>
		 
		 <?php if (isset($error)) echo '<script type="text/javascript"> window.onload = function() { alert("Неверный логин или пароль."); }</script>'; ?>

		</div>

    <?php else: ?>
	<div>
	<?php echo '<script type="text/javascript"> document.body.style.backgroundImage = "url(\'backgrbit.png\')"; </script>' ; ?>
	
        <form method="post" class="loginContent" id="recover">
            <h1>Введите пин-код</h1><br>
            <div class="recoverBlock">
                <input name="num1" type="text" id="pinDigit1" maxlength="1" size="1" style="text-align: center;" required/>
				<button type="submit" id="showModal" hidden>null</button>
                <input name="num2" type="text" id="pinDigit2" maxlength="1" size="1" style="text-align: center;" required/>
                <input name="num3" type="text" id="pinDigit3" maxlength="1" size="1" style="text-align: center;" required/>
                <input name="num4" type="text" id="pinDigit4" maxlength="1" size="1" style="text-align: center;" required/>
            </div>
            <button type="submit">Отправить</button>
            <?php if (isset($error)) echo '<script type="text/javascript"> window.onload = function() { alert("Неверный пин-код"); }</script>'; ?>
        </form>
	</div>	
    <?php endif; ?>
	  </div>
	  
	<!-- Модальное окно с подсказками -->
    <div id="myModal" class="modal">
       <div class="modal-content">
         <span class="close">&times;</span>
		 <h1>Хорошо, попробую намекнуть...</h1><br>
		 <ul>
		 <li id="help1" class="li">О, как! Нашли кнопку помощи! Для начала неплохо...</li>
		 <li id="help2" class="li">Вспомни, что такое DevTools. Он точно должен помочь.</li>
		 <li id="help3" class="li">А может быть форма авторизации что-то скрывает? Разве она должна быть желтого цвета?</li>
		 <li id="help4" class="li">Мне кажется, что разработчик сайта забыл удалить из исходников некоторые чувствительные данные...</li>
		 <li id="help5" class="li">А не заглянуть ли нам в исходный код страницы?</li>
		 <li id="help6" class="li">Иногда дизайнеры сайтов оставляют комментарии в файлах Cascading Style Sheets...</li>
		 <li id="help7" class="li">Что же это за зверь такой - Base64, а?</li>
		 <li id="help8" class="li">Если существует двоичная система исчисления, то почему в жизни мы пользуемся десятичной?</li>
		 </ul>
       </div>
    </div>

<script type="text/javascript">
		var helpnum = 1;

         // Получаем модальное окно
         var modal = document.getElementById("myModal");

         // Получаем кнопку, которая открывает модальное окно
         var btn = document.getElementById("showModal");

         // Получаем элемент <span>, который закрывает модальное окно
         var span = document.getElementsByClassName("close")[0];

         // Когда пользователь кликает на ссылку, открываем модальное окно
         btn.onclick = function() {
			if (helpnum == 1) {
				help1.style.display = "block";
				help2.style.display = "none";
				help3.style.display = "none";
				help4.style.display = "none";
				help5.style.display = "none";
				help6.style.display = "none";
				help7.style.display = "none";
				help8.style.display = "none";
			}
			if (helpnum == 2) {
				help1.style.display = "none";
				help2.style.display = "block";
				help3.style.display = "none";
				help4.style.display = "none";
				help5.style.display = "none";
				help6.style.display = "none";
				help7.style.display = "none";
				help8.style.display = "none";
			}
			if (helpnum == 3) {
				help1.style.display = "none";
				help2.style.display = "none";
				help3.style.display = "block";
				help4.style.display = "none";
				help5.style.display = "none";
				help6.style.display = "none";
				help7.style.display = "none";
				help8.style.display = "none";
			}
			if (helpnum == 4) {
				help1.style.display = "none";
				help2.style.display = "none";
				help3.style.display = "none";
				help4.style.display = "block";
				help5.style.display = "none";
				help6.style.display = "none";
				help7.style.display = "none";
				help8.style.display = "none";
			}
			if (helpnum == 5) {
				help1.style.display = "none";
				help2.style.display = "none";
				help3.style.display = "none";
				help4.style.display = "none";
				help5.style.display = "block";
				help6.style.display = "none";
				help7.style.display = "none";
				help8.style.display = "none";
			}
			if (helpnum == 6) {
				help1.style.display = "none";
				help2.style.display = "none";
				help3.style.display = "none";
				help4.style.display = "none";
				help5.style.display = "none";
				help6.style.display = "block";
				help7.style.display = "none";
				help8.style.display = "none";
			}
			if (helpnum == 7) {
				help1.style.display = "none";
				help2.style.display = "none";
				help3.style.display = "none";
				help4.style.display = "none";
				help5.style.display = "none";
				help6.style.display = "none";
				help7.style.display = "block";
				help8.style.display = "none";
			}
			if (helpnum == 8) {
				help1.style.display = "none";
				help2.style.display = "none";
				help3.style.display = "none";
				help4.style.display = "none";
				help5.style.display = "none";
				help6.style.display = "none";
				help7.style.display = "none";
				help8.style.display = "block";
			}						
			helpnum++;
			if (helpnum == 9) { helpnum = 2 };
		    modal.style.display = "block";
         }

         // Когда пользователь кликает на <span> (кнопка закрытия), закрываем модальное окно
         span.onclick = function() {
           modal.style.display = "none";
         }

         // Когда пользователь кликает в любом месте вне модального окна, закрываем его
         window.onclick = function(event) {
           if (event.target == modal) {
             modal.style.display = "none";
           }
         }
      </script>
	  
   </body>
</html>
