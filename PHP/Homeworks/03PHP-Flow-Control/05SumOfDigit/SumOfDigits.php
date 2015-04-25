<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 19/08/14
 * Time: 23:48
 * Write a PHP script SumOfDigits.php which receives a comma-separated list of integers from an input form and creates a two-column table. The first column should contain each of the values from the input. The second column should contain the sum of the digits of each value. If the value is not an integer number, print "I cannot sum that". Styling the page is optional
 */
function sumDigits($sum){
if(is_int($sum)){
$arr = str_split($sum);
return array_sum($arr);
}else{
    return 'I cannot sum that';
}
}

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
	<title>SumOfDigits</title>
    <style>
        table tr td {
            border: 1px solid black;
        }
        table th {
            border: 1px solid black;
        }
        table {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<form action="<?php $_PHP_SELF;?>" method="post">
    <label for="input">Input string: </label>
    <input type="text" name="input" id="input"/>
    <input type="submit" name="submit" value="Submit"/>
</form>
<?php
if(isset($_POST['submit'])){
    $arr = explode(', ', $_POST['input']);
    for ($i = 0; $i < count($arr); $i++) {
        if(intval($arr[$i]) == 0){
            continue;
        }
      $arr[$i]=intval($arr[$i]);

    }

?>
<table>
<?php
    for ($i = 0; $i < count($arr); $i++) {
      echo('<tr><td>'.$arr[$i].'</td><td>'.sumDigits($arr[$i]).'</td></tr>');
    }
}
?>
</table>
</body>
</html>