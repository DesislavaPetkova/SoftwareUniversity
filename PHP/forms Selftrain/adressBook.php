<?php
$pageTitle = "List";
include 'includes/header.php';
$groups = array(1=>'Приятели', 2=>'Бивши', 3=>'Колеги', 4=>'Семейство');
?>
	<a href="form.php">Добави нов контакт</a>
	<table border = 1>
		<tr>
			<th>Име</th>
			<th>Телефон</th>
			<th>Група</th>
		</tr>
		<?php

		if (file_exists('data.txt')) {
			$result = file('data.txt');
			foreach ($result as $value) {
				$columns=explode('!',$value);
				echo '<tr>
				<td>'.$columns[0].'</td>
				<td>'.$columns[1].'</td>
				<td>'.$groups[trim($columns[2])].'</td>
				</tr>';
			}
		}

		?>
	</table>
<?php
include 'includes/footer.php';
?>


