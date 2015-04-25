<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 28/08/14
 * Time: 16:56
 *The SoftUni team is developing a new layer of defense against email spam. Help them by writing a PHP program that reads a text and blacklist, censors the blacklisted emails in the text, and prints the rest of the emails as HTML hyperlinks.
You will receive a text and a blacklist. The text contains several emails. For example, in the following text there are 4 email addresses:
“Hi, I'm an air-conditioner technician, so if you need any assistance you can contact me at air-conditioners@gmail.com . Secondary email: kinky_technician@yahoo.in or at naked-screwdriver@abv.bg OR pesho@dir.tk”
The blacklist contains 3 entries: *.bg, pesho@dir.tk, *.com. The asterisk * denotes any email address which ends with that signature. Full email addresses denote a specific email address.
Among the 4 email addresses in the text, there are 3 that should be censored:
•	air-conditioners@gmail.com – ends with .com
•	naked-screwdriver@abv.bg – ends with .bg
•	pesho@dir.tk – specifically mentioned in the blacklist
The censored emails should be replaced with asterisks equal to their length.
“Hi, I'm an air-conditioner technician, so if you need any assistance you can contact me at ************************** . Secondary email: kinky_technician@yahoo.in or at ************************ OR ***************”
The only email whose domain is missing from the blacklist and is not directly mentioned is kinky_technician@yahoo.in. As such, it should be replaced as an HTML hyperlink in the format
<a href="mailto:[email]">[email]</a> in the same text.
Input
The input will be read from an HTTP GET request. The text will be received from a text input field with name 'text'. The blacklist will be received from a textarea with name 'blacklist', holding each entry on a separate line.
Output
The resulting text should be printed as an HTML paragraph (enclosed with <p></p> tags). The email addresses should be printed according to the rules above.
Constraints
•	There will be no more than 10 entries in the blacklist.
•	All valid emails in the text will be in the format  xxxx@yyyy.zzz and will follow these rules:
o	xxxx will only contain 1 or more numbers, Latin letters, +, _ and -
o	yyyy will only contain 1 or more numbers, Latin letters and –
o	zzz will only contain 1 or more numbers, Latin letters, - and .

 */
?>
<?php

$text = $_GET['text'];
//var_dump($text);
//$text = "Hi, I'm an air-conditioner technician, so if you need any assistance you can contact me at air-conditioners@gmail.com . Secondary email: kinky_technician@yahoo.in or at naked-screwdriver@abv.bg OR pesho@dir.tk";
$blacklist  = $_GET['blacklist'];
//$blacklist = '*.bg
//pesho@dir.tk
//*.com
//';
$pattern = '/\b[0-9A-Za-z\_\+\-]+@[0-9A-Za-z\-]+\.[0-9A-Za-z\-\.]+\b/';

preg_match_all($pattern, $text, $result);
$blacklist = preg_split('/[\n\r]+/', $blacklist, -1, PREG_SPLIT_NO_EMPTY);

for ($i = 0; $i < count($blacklist); $i++) {
  $blacklist[$i]= str_replace('*', '',$blacklist[$i]);
}

$arr = array_shift($result);
$patterns= array();
for ($i = 0; $i < count($arr); $i++) {
  $patterns[]= "/$arr[$i]/";
}

for ($i = 0; $i < count($arr); $i++) {
  for ($j = 0; $j < count($blacklist); $j++) {
    if(strpos($arr[$i], $blacklist[$j]) !=0 || strpos($arr[$i], $blacklist[$j])===0){
        $arr[$i]= str_repeat('*', strlen($arr[$i]));
    }
  }
}
//var_dump($arr);
for ($i = 0; $i < count($arr); $i++) {
  if(!(strpos($arr[$i], '*')===0)){
    $arr[$i]= "<a href=\"mailto:$arr[$i]\">$arr[$i]</a>";
  }
}
//var_dump($arr);
for ($i = 0; $i < count($arr); $i++) {
 $text= preg_replace($patterns[$i], $arr[$i], $text);
}
$text = "<p>".$text."</p>";
echo $text;
//var_dump($text);

?>