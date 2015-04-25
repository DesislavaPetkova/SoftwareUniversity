<?php
/**
 * Created by PhpStorm.
 * User: *******
 * Date: 22/08/14
 * Time: 17:19
 * Write a PHP program URLReplacer.php that takes a text from a textarea and replaces all URLs with the HTML syntax <a href= "…" ></a> with a special forum-style syntax [URL=…][/URL].
 */

?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8"/>
    <title>URLReplacer</title>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <textarea name="tarea" id="" cols="30" rows="10" placeholder="Enter your text here"></textarea>
    <input type="submit" name="submit" value="Submit"/>
</form>
<?php
if(isset($_POST['submit'])){
    $text = $_POST['tarea'];
    $patterns=array('/<a href="/', '/">/', '/<\/a>/');
    $replacements= array('[URL=', ']', '[/URL] ');
    for ($i = 0; $i < 3; $i++) {
     $text = preg_replace($patterns[$i], $replacements[$i], $text);
    }
echo($text);


}
?>
</body>
</html>