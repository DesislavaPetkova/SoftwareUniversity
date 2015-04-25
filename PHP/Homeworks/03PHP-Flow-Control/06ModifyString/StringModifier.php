<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 20/08/14
 * Time: 12:29
 * Write a PHP script StringModifier.php which receives a string from an input form and modifies it according to the selected option (radio button). You should support the following operations: palindrome check, reverse string, split to extract leters only, hash the string with the default PHP hashing algorithm, shuffle the string characters randomly. The result should be displayed right under the input field. Styling the page is optional. Think about which of the modification can be achieved with already built-in functions in PHP. Where necessary, write your own algorithms to modify the given string. Hint: Use the crypt() function for the "Hash String" modification.
 */
function palindrome($string){

    if ((strlen($string) == 1) || (strlen($string) == 0)) {
        echo $string." IS PALINDROME!";
    }

    else {

        if (substr($string,0,1) == substr($string,(strlen($string) - 1),1)) {
            echo $string." IS PALINDROME!";;
        }
        else { echo $string." IS NOT A PALINDROME!"; }
    }
}
function reverseString ($string){
    $arr = str_split($string);
    $arr = array_reverse($arr);
    return implode('', $arr);

}
function splitString($string){
    $arr = str_split($string);
        foreach ($arr as $value) {
            echo($value.' ');
        }
}
function hashed($string){
    echo crypt($string);
}
function shuffleString($string){
    $arr = str_split($string);
    shuffle($arr);
        foreach ($arr as $value) {
            echo $value;
        }
}

?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
	<title>StringModifier</title>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <input type="text" name="input"/>
    <input type="radio" name="radio" id="palindrome" value="1"/>
    <label for="palindrome">Check Palindrome</label>
    <input type="radio" name="radio" id="reverse" value="2"/>
    <label for="reverse">Reverse String</label>
    <input type="radio" name="radio" id="split" value="3"/>
    <label for="split">Split</label>
    <input type="radio" name="radio" id="hash" value="4"/>
    <label for="hash">Hash String</label>
    <input type="radio" name="radio" id="shuffle" value="5"/>
    <label for="shuffle">Shuffle String</label>
    <input type="submit" name="submit" value="Submit"/>
</form>
<?php
if(isset($_POST['submit'])){
switch ($_POST['radio']){
    case 1:
        palindrome($_POST['input']);
        break;
    case 2:
        echo reverseString($_POST['input']);
        break;
    case 3:
        splitString($_POST['input']);
        break;
    case 4:
        hashed($_POST['input']);
        break;
    case 5:
        shuffleString($_POST['input']);
        break;
}
}
?>
</body>
</html>