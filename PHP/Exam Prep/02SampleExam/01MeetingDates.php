<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 29/08/14
 * Time: 20:55
 * A NGO called “Obshtestvo” has its regular meetings every Thursday of the month. They need a script to generate all dates between 2 given dates, so they can plan other events accordingly.
Your task is to write a PHP program that reads 2 dates, calculates all Thursdays in that period, and prints each date in the format "d-m-Y" in an ordered list in HTML.
Assume that the first week of the month is where the first Thursday is. For example, we are given the dates: 02-06-2014 and 31-08-2014. There are 13 Thursdays in the time period. We print each of those dates as list items in an ordered list.
1.	05-06-2014
2.	12-06-2014
3.	19-06-2014
4.	26-06-2014
5.	03-07-2014
6.	10-07-2014
7.	17-07-2014
8.	24-07-2014
9.	31-07-2014
10.	07-08-2014
11.	14-08-2014
12.	21-08-2014
13.	28-08-2014

In case no Thursdays are found, only print "No Thursdays" in <h2></h2> heading tags.
Input
The input will be read from an HTTP GET request. The first date will be received from a text input field with name 'dateOne'. The second date will be received from a text input field with name 'dateTwo'.
Output
If there are no Thursdays in the given period, "No Thursdays" should be printed. Otherwise, print each Thursday in <li></li> tags in an ordered list <ol></ol>. The output should be formatted exactly like in the example below.
Constraints
•	All dates will be in the format "d-M-Y".
•	Date two CAN be before date one.

 */

?>
<?php
date_default_timezone_set("Europe/Sofia");
$dateOneString = $_GET['dateOne'];
//$dateOneString = '02-06-2014';
$dateTwoString = $_GET['dateTwo'];
//$dateTwoString = '31-08-2014';
$dateOne = parseDate($dateOneString);
$dateTwo= parseDate($dateTwoString);
$dateArr=[];
while ($dateOne < $dateTwo){
    $dateOne->add(DateInterval::createFromDateString('1 day'));
    $dateArr[] = $dateOne->format('d-m-Y');

}
//var_dump($dateArr);
$resultArr= [];
foreach ($dateArr as $day) {
    if(isThursday($day)){
        array_push($resultArr, $day);
    }
}
if(count($resultArr) >0){
    echo "<ol>";
    for ($i = 0; $i < count($resultArr); $i++) {
      echo "<li>".$resultArr[$i]."</li>";
    }
    echo"</ol>";
}else{
    echo "<h2>No Thursdays</h2>";
}
function parseDate ($date){
    $date = DateTime::createFromFormat('d-m-Y', $date);
    $date->setTime(0,0);
    return $date;
}
function isThursday($date){
    $weekDay = date("w", strtotime($date));

    if($weekDay == 4){
        return $date;
    }else {
        return false;
    }
}
?>