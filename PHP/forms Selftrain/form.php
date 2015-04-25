<?php
mb_internal_encoding('UTF-8');
// print_r($_POST);
$pageTitle = "Form";
include 'includes/header.php';
$groups = array(1=>'Приятели', 2=>'Бивши', 3=>'Колеги', 4=>'Семейство');

if ($_POST) {
	$username=trim($_POST['username']);
	$username=str_replace('!', '', $username);
	$phone=trim($_POST['phone']);
	$phone=str_replace('!', '', $phone);
	$selectedGroup=(int)$_POST['group'];
	$error=false;
	// echo mb_strlen($username, 'UTF-8');
	if (mb_strlen($username) < 4) {
		echo '<p> Името е прекалено късо</p>';
		$error=true;
	}
	if (mb_strlen($phone)<6 || mb_strlen($phone)>12) {
		echo '<p> Невалиден телефон</p>';
		$error=true;
	}
	if (!array_key_exists($selectedGroup, $groups)) {
		echo '<p>Невалидна група</p>';
		$error=true;
	}
	if (!$error) {
		$result=$username.'!'.$phone."!".$selectedGroup."\n";
		// echo $result.'<br>';
		if(file_put_contents('data.txt', $result, FILE_APPEND)){
			echo "Записът е успешен";
		}
	}
}



?>
	<a href="adressBook.php">Списък</a>
	<form action="" method="POST" style="display: block">
		<label for="username">Име</label>
		<input type="text" name="username" id="username" placeholder="username"/><br>
		<label for="phone">Телефон</label>
		<input type="text" name="phone" id="phone" placeholder="Phone"/><br>
		<select name="group">
			<?php
				foreach ($groups as $key=>$value) {
					echo '<option value="'.$key.'">'.$value.'</option>';
				}
			?>
		</select>
		<input type="submit" value="Добави" style="display: block;">
	</form>
<?php
include 'includes/footer.php';
?>