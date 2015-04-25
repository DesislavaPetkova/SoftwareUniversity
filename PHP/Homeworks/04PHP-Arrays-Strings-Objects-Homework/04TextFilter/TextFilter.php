<?php
/**
 * Created by PhpStorm.
 * User: *****
 * Date: 22/08/14
 * Time: 12:02
 * Write a PHP program TextFilter.php that takes a text from a textfield and a string of banned words from a text input field. All words included in the ban list should be replaced with asterisks "*", equal to the word’s length. The entries in the banlist will be separated by a comma and space ", ".
 */


?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8"/>
	<title>TextFilter</title>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <textarea name="tarea" id="" cols="30" rows="10" placeholder="Enter your text here"></textarea>
    <input type="text" name="banlist" placeholder="Enter your banlist here"/>
    <input type="submit" name="submit" value="Submit"/>

</form>
<?php
    if(isset($_POST['submit'])){
        $text = $_POST['tarea'];
        $patterns = explode(', ', $_POST['banlist']);
        for ($i = 0; $i < count($patterns); $i++) {
          $patterns[$i]= '/'.$patterns[$i].'/';
        }
        $replacements = [];
        for ($i = 0; $i < count($patterns); $i++) {
            $replace='';
          for ($j = 0; $j < strlen($patterns[$i]) -2; $j++) {
            $replace = $replace.'*';
          }
            $replacements[] = $replace;
            $replace='';
        }
//        var_dump($replacements);
        for ($h = 0; $h < count($replacements); $h++) {
          $text = preg_replace($patterns[$h], $replacements[$h], $text);
        }

        echo($text);


    }
?>
</body>
</html>