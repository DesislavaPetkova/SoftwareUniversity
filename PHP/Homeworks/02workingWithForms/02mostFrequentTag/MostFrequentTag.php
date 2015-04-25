<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 14/08/14
 * Time: 13:27
 * Write a PHP script MostFrequentTag.php which generates an HTML input text field and a submit button. In the text field the user must enter different tags, separated by a comma and a space (", "). When the information is submitted, the script should generate a list of the tags, sorted by frequency. Then you must print: "Most Frequent Tag is: [most frequent tag]". Semantic HTML is required. Styling is not required.
 */

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>printTags</title>
</head>
<body>
<form action="" method="POST">
    <p>Enter Tags:</p>
    <input type="text" name="tags">
    <input type="submit" value="Submit" name="submit" >
</form>
<?php


if(isset($_POST['tags'])){
    $arr = explode(', ', $_POST['tags']);
    arsort($arr);
    $result = array_count_values($arr);
    foreach ($result as $key=>$value) {
        echo $key." : ".$value.'<br>';
    }


    echo '<br>'.'Most Frequent Tag is: '.array_shift($arr);
}
?>
</body>
</html>