<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 19/08/14
 * Time: 17:38
 * You are a very rich billionaire with an unhidden passion for cars. You like certain car manufacturers but you don’t really cre about anything else, and that’s why you need your own randomizing algorithm that helps you decide how many and what color cars you should buy. Write a PHP script CarRandomizer.php that receives a string of cars from an input HTML form, separated by a comma and space (“, “). It then prints each car, a random color and a random quantity in a table like the one shown below. Use colors by your choice. Use as quantity a random number in range [1...5]. Styling the page is optional.
 */

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
	<title>CarRandomizer</title>
    <style>
        table {
            border: 1px solid black;
            margin-left: 50px;
            margin-top: 15px;
        }
        table tr td {
            border: 1px solid black;
            padding: 3px;
        }
        table th {
            border: 1px solid black;
        }

    </style>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <label for="enter">Enter cars</label>
    <input name="cars" type="text" id="enter" required="true"/>
    <input type="submit" name="submit" value="Show result"/>
</form>
<?php
if (isset($_POST['submit'])){
$arrCars = explode(", ",$_POST['cars']);
$colorsArr = array('yellow', 'black', 'red', 'brown', 'blue', 'purple');
?>
<table>
    <thead>
    <tr>
        <th>Car</th>
        <th>Color</th>
        <th>Count</th></tr>
    </thead>
    <tbody>
<?php
    for ($i = 0; $i < count($arrCars); $i++) {
        $randomColor = rand(1,5);
        echo('<tr><td>'.$arrCars[$i].'</td><td>'.$colorsArr[$randomColor].'</td><td>'.$randomColor.'</td></tr>');
    }
}
?>

    </tbody>
</table>

</body>
</html>