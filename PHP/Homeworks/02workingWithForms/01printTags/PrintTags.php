<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 14/08/14
 * Time: 13:27
 * Write a PHP script PrintTags.php which generates an HTML input text field and a submit button. In the text field the user must enter different tags, separated by a comma and a space (", "). When the information is submitted, the script should split the tags, put them in an array and print out the array. Semantic HTML is required. Styling is not required.
 */

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>printTags</title>
</head>
<body>
<form action="printTags.php" method="POST">
    <p>Enter Tags:</p>
    <input type="text" name="tags">
    <input type="submit" value="Submit" name="submit" >
</form>
<?php
if($_SERVER['REQUEST_METHOD']==='POST'){
    $arr = explode(', ', $_POST['tags']);

    foreach ($arr as $key=>$value) {
        echo $key.' : '.htmlspecialchars($value).'<br>';
    }
}
?>
</body>
</html>