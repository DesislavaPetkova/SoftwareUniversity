<?php
/**
 * Created by PhpStorm.
 * User: ******
 * Date: 21/08/14
 * Time: 17:07
 * Write a PHP program WordMapper.php that takes a text from a textarea and prints each word and the number of times it occurs in the text. The search should be case-insensitive. The result should be printed as an HTML table.
 */
if(isset($_POST['tarea'])){
    $string = strtolower($_POST['tarea']);
    $arr = preg_split("/\W+/", $string, -1, PREG_SPLIT_NO_EMPTY);;
    $result = array_count_values($arr);

?>
<!DOCTYPE html>
<html>
<head>
    <style>
        table {
            border: 1px solid black;
        }
        table tr td {
            border: 1px solid black;
            padding: 2px;
        }
    </style>
    <meta charset="utf-8"/>
    <title>WordMapper</title>
</head>
<body>
<table>
<?php
    foreach ($result as $key=>$value) {
        echo '<tr><td>'.$key.'</td><td>'.$value.'</td></td>' ;
    }


?>
</table>
</body>
</html>
<?php
die;
}
?>
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
	<title>WordMapper</title>
</head>
<body>

<form action="<?php $_PHP_SELF;?>" method="post">
    <textarea name="tarea"  cols="30" rows="2"></textarea>
    <input type="submit" name="submit" value="Count words"/>
</form>
</body>
</html>