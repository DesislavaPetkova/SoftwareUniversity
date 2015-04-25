<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 28/08/14
 * Time: 13:47
 * Write a PHP program that reads a textfield, holding a text, and several other option fields, formats the text according to the options selected and prints the new text in HTML format.
You will read the following data:
•	Text
•	Hash value
•	Font size
•	Font style – "normal”, "bold", "italic"
Your task is to modify the text based on the data received. The text modification is as follows:
First, the text is hashed by reducing / increasing the ASCII value of each text character by the hash value. If the character’s position is even, the ASCII value is increased, and if it’s odd – the value is decreased. For example, we are given the following text and a hash value of 1:
"Warning: Our encryption is unbreakable and you will not be able to decrypt your information!"
After hashing each letter form the text (W+1=X, a-1=`, r+1=s, etc.), the result would be:
"X`smjmh9!Nvq!dobsxqsjno¬jr!toasdbjbamd!`oc!xpt!vjkm¬onu¬cd!`ckf¬un!cfbsxqs!xpts¬jmgnslbsjno"
The text is then added in an HTML paragraph inside <p></p> tags. The font size and style are added as styles to the paragraph as follows:
<p style="font-size:[fontSize];font-style:[fontStyle];font-weight:bold;">[text]</p>
If the style is normal or italic, print it with font-style. If it’s bold, print it with font-weight. The style can be only one.
So if the font size is 30 and the style is bold, the output would be:
<p style="font-size:30;font-weight:bold;">X`smjmh9!Nvq!dobsxqsjno¬jr!toasdbjbamd!`oc!xpt!vjkm¬onu-cd!`ckf¬un!cfbsxqs!xpts¬jmgnslbsjno </p>
Input
The input will be read from an HTTP GET request. The text will be received from a text input field with name 'text'. The hash value will be received from a text input field with name 'hashValue'. The font-size will be received from a text input field with name 'fontSize'. The style will be received from an input field with name 'style'.
Output
The resulting paragraph should be printed as output.
Constraints
•	The hash value will be a number in the range [0..10]
•	The font-size will be a number in the range [1..100]
•	The style can only be one of the three – normal, italic or bold.

 *
 */
?>
<?php
$text = $_GET['text'];
$hashValue = $_GET['hashValue'];
$fontSize = $_GET['fontSize'];
$style = $_GET['fontStyle'];
$fontStyle= 'font-style:normal;';
if($style == 'italic'){
    $fontStyle="font-style:italic;";
}
if($style == "bold"){
    $fontStyle = "font-weight:bold;";
}

$text = str_split($text);
for ($i = 0; $i < count($text); $i++) {
  if($i%2==0){
      $text[$i] = chr(ord($text[$i])+$hashValue);
  }else {
      $text[$i]= chr(ord($text[$i])-$hashValue);
  }
}
$text = implode('', $text);
echo "<p style=\"font-size:$fontSize;$fontStyle\">$text</p>";


?>