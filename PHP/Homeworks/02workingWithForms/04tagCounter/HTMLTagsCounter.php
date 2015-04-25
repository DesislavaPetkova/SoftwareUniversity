<?php
session_start();
$tagsArr = array('html', 'body', 'head', 'title', 'form', 'meta', 'section', 'article', 'aside', 'header', 'footer');
$counter = 0;

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <title>Tag Counter</title>
</head>
<body>
<form action="<?php $_PHP_SELF?>" method="POST">
    <label for="enter">Enter HTML tags:</label><br>
    <input type="text" id="enter" name="tags"/>
    <input type="submit" name="submit" value="Submit"/>
</form>
<?php
if(isset($_POST['submit'])){

    $tags = $_POST['tags'];
    foreach ($tagsArr as $value) {
        if ($tags == $value){
            $_SESSION['counter']++;
            echo '<h1>Valid HTML tag!</h1>';
            echo('<h1>Score:'.$_SESSION['counter'].'</h1>');
        }

    }
    if (!in_array($tags, $tagsArr)){
        echo('<h1>Invalid HTML tag!</h1>');
        echo('<h1>Score:'.$_SESSION['counter'].'</h1>');
    }
}
?>
</body>
</html>