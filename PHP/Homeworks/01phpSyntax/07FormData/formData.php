<?php 
$result = '';
$name = $_POST['name'];
$age = $_POST['age'];
$genre = $_POST['genre'];
$result = "My name is $name. I am $age years old. I am $genre.";
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<title>Form</title>
</head>
<body>
<form action="formData.php" method="POST">
	<input type="text" name="name" placeholder="Name" style="display: block">
	<input type="text" name="age" placeholder="Age" style="display: block">
	<input type="radio" name="genre" value="Male">Male
	<input type="radio" name="genre" value="Female">Female
	<input type="submit" name="submit" value="Изпращане" style="display: block">
</form>
<?php echo $result; ?>
</body>
</html>