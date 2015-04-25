<?php
/**
 * Created by PhpStorm.
 * User: *******
 * Date: 22/08/14
 * Time: 16:40
 *Write a PHP program SentenceExtractor.php that takes a text from a textarea and a word from an input field and prints all sentences from the text, containing that word. A sentence is any sequence of words ending with ., ! or ?.
 */

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8"/>
    <title>SentenceExtractor</title>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <textarea name="tarea" id="" cols="30" rows="10" placeholder="Enter your text here"></textarea>
    <input type="text" name="word" placeholder="Word"/>
    <input type="submit" name="submit" value="Submit"/>

</form>
<?php
if(isset($_POST['submit'])){
    $text = $_POST['tarea'];
    $word = $_POST['word'];
    $arrSentences = preg_split('/(?<=[.!?]|[.!?][\'"])\s+/', $text, -1, PREG_SPLIT_NO_EMPTY);
    for ($i = 0; $i < count($arrSentences); $i++) {
        $temp = explode(' ', $arrSentences[$i]);
      if(in_array($word, $temp) && preg_match('/(\s+)' . $word . '\1(.*)[.?!]/', $arrSentences[$i])){
        echo($arrSentences[$i] . '<br>');
      }
    }




}
?>
</body>
</html>