<?php
/**
 * Created by PhpStorm.
 * User: *****
 * Date: 21/08/14
 * Time: 17:44
 * Write a PHP program TextColorer.php that takes a text from a textfield, colors each character according to its ASCII value and prints the result. If the ASCII value of a character is odd, the character should be printed in blue. If it’s even, it should be printed in red.
 */
if(isset($_POST['tarea'])){
    $arr = explode(' ', $_POST['tarea']);
    $arr = str_split(implode(' ', $arr));
    for ($i = 0; $i < count($arr); $i++) {
      if(ord($arr[$i]) % 2 ==1){
          echo("<p style=\""."color: blue\"".">".$arr[$i]."</p>".' ');
      } else{
          echo("<p style=\""."color: red\"".">".$arr[$i]."</p>".' ');
      }
    }

}
?>
<!DOCTYPE html>
<html>
<head>
    <style>
        p{
            display: inline-block;
        }
    </style>
    <meta charset="utf-8"/>
	<title>Text Colorer</title>
</head>
<body>
<?php
die;
?>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <textarea name="tarea"  cols="30" rows="3"></textarea><br>
    <input type="submit" name="submit" value="Color text"/>
</form>
</body>
</html>