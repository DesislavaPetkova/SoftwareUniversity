<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 19/08/14
 * Time: 20:26
 * Write a PHP script AnnualExpenses.php that receives n years from an input HTML form and creates a table (like the one shown below) with random expenses by months and the corresponding years (n years back). For example, if N is 10, create a table that shows the expenses for each month for the last 10 years. Add a "Total" column at the end, showing the total expenses for the same year. The random expenses in the table should be in the range [0…999]. Styling the page is optional.
 */


?>
<!DOCTYPE html>
<html>
<head>
    <style>
        table {
            border: 1px solid black;
            margin-left: 50px;
            margin-top: 15px;
        }
        table tr td {
            border: 1px solid black;
            padding: 3px;
        }
        table th {
            border: 1px solid black;
        }
    </style>
    <meta charset="utf-8"/>
	<title>AnnualExpenses</title>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <label for="enter">Enter number of years: </label>
    <input type="text" name="years" id="enter"/>
    <input type="submit" name="submit" value="Show costs"/>
</form>
<?php
if (isset($_POST['submit'])){
    $nYears = htmlentities($_POST['years']);


}
?>
<table>
    <thead>
    <tr>
        <th>Year</th>
        <th>January</th>
        <th>February</th>
        <th>March</th>
        <th>April</th>
        <th>May</th>
        <th>June</th>
        <th>July</th>
        <th>August</th>
        <th>September</th>
        <th>October</th>
        <th>November</th>
        <th>December</th>
        <th>Total</th>
    </tr>
    </thead>
<?php
$year = 2014;

for ($i = 0; $i < $nYears; $i++) {
$total = 0;
echo '<tr><td>'.$year.'</td>';
  for ($j = 0; $j < 12; $j++) {
    $random = rand(0, 999);
    echo('<td>'.$random.'</td>');
    $total += $random;
  }
echo('<td>'.$total.'</td></tr>');
$total = 0;
$year--;
}
?>
</table>
</body>
</html>