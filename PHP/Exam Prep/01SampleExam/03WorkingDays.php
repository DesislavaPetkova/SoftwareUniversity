<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 29/08/14
 * Time: 15:17
 *Summer is coming to an end and it’s time for people to go back to work – including you. Well, who needs the beach when you have PHP exams! Right..? …
Your task is to write a PHP program that reads 2 dates and several holidays, calculates the workdays in that period, and prints each workday date in the format "d-m-Y" in an ordered list in HTML.
Assume that a workday is any day of the week from Monday to Friday and is NOT in the given holidays. For example, we are given the dates: 17-12-2014 and 31-12-2014 and the holidays 31-12-2014, 24-12-2014, 08-12-2014. There are 14 days in the time period between 17-12-2014 and 31-12-2014. After subtracting all weekends (Saturdays and Sundays) and holidays, there are a total of 9 workdays left. Finally, we print each of those dates as list items in an ordered list.
1.	17-12-2014
2.	18-12-2014
3.	19-12-2014
4.	22-12-2014
5.	23-12-2014
6.	25-12-2014
7.	26-12-2014
8.	29-12-2014
9.	30-12-2014
In case no workdays are found, only print "No workdays" in <h2></h2> heading tags.
Input
The input will be read from an HTTP GET request. The first date will be received from a text input field with name 'dateOne'. The second date will be received from a text input field with name 'dateTwo'. The holidays will be received from a textarea with name 'holidays', holding each holiday on a separate line.
Output
If there are no workdays in the given period, "No workdays" should be printed. Otherwise, print each workday in <li></li> tags in an ordered list <ol></ol>. The output should be formatted exactly like in the example below.
Constraints
•	The holidays will be no more than 10.
•	All dates will be in the format "d-M-Y".
•	Date two will NOT be before date one.

 */

?>

<?php
date_default_timezone_get('UTC');
$dateOneText = $_GET['dateOne'];
$dateOneText = '17-12-2014';
$dateTwoText = $_GET['dateTwo'];
$dateTwoText = '31-12-2014';
$holidays= '31-12-2014
24-12-2014
08-12-2014';
$holidaysDatesText= preg_split('/\s+/', $holidays, -1, PREG_SPLIT_NO_EMPTY);

//var_dump($holidaysDatesText);
$holidays = [];
foreach ($holidaysDatesText as $holidayText) {
    $holiday = parseDateString($holidayText);
    $holidays[] = $holiday;
//    var_dump($holidays);
}

$dateOne = parseDateString($dateOneText);
$dateTwo = parseDateString($dateTwoText);
$date = $dateOne;
$workingDays= [];
while($date <= $dateTwo){
    $date = $date->add(DateInterval::createFromDateString('1 day'));
    if (isWorkingDay ($date, $holidays)){
        array_push($workingDays, clone($date));
    }
//    var_dump($date);

}
//var_dump($workingDays);
if (count($workingDays) == 0){
    echo'<h2>No workingDay days</h2>';
}else {
    echo "<ol>";
    foreach ($workingDays as $workingDay) {
        echo "<li>";
        echo $workingDay->format("d-m-Y");
        echo "</li>";
    }

    echo "</ol>";
}








function isWorkingDay (DateTime $date, array $holidays){
    $tempDate = $date->format('d-m-Y');
    $dayOfWeek = date('w', strtotime($tempDate));
    if($dayOfWeek == 0 && $dayOfWeek == 6){
        return false;
    }
    if(in_array($date, $holidays)){
        return false;
    }
    return true;
}


function parseDateString ($date){
    $newDate = DateTime::createFromFormat('d-m-Y', $date);
    $newDate->setTime(0,0);
    return $newDate;
}
?>