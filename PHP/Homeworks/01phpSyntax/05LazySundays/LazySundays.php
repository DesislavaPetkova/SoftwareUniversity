<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 13/08/14
 * Time: 13:12
 * Write a PHP script LazySundays.php which prints the dates of all Sundays in the current month.
 */
$month = date("F");
$year = date("Y");
$totalDays = date("t");

for($i = 1; $i <= $totalDays; $i++) {
    $date = strtotime("$i $month $year");
    if(date("l", $date) == "Sunday") {
        echo date("jS F, Y", $date) . "\n";
    }
}
?>
