<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 19/08/14
 * Time: 13:50
 * Write a PHP script SquareRootSum.php that displays a table in your browser with 2 columns. The first column should contain a number (from 0 to 100) and the second column should contain the square root of that number, rounded to the second digit after the decimal point. The last row of the table should contain the sum of all values in the Square column. Styling the page is optional.
 */
$total = 0;
echo('<!DOCTYPE html>
<html>
<head>
    <style>
    table {
    border: 1px solid black;
    }
    table td{
    border: 1px solid black;
    }
    table th {
    border: 1px solid black;
    }
    </style>
    <meta charset="utf-8"/>
    <title>SquareRootSum</title>
</head>
<body>
<table>
    <thead>
    <tr>
        <th>Number</th>
        <th>Square</th>
    </tr>
    </thead>
    <tbody>
     ');
for ($i = 0; $i < 100; $i+=2) {
  echo('<tr><td>'.$i.'</td><td>'.round((sqrt($i)), 2).'</td></tr>');
    $total+= round((sqrt($i)), 2);
}

echo ('
    </tbody>
    <tfoot>
    <tr>
        <td style="font-weight: bold">Total:</td>
        <td>'.$total.'</td>
    </tr>
    </tfoot>
</table>
</body>
</html>');
?>
