<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 13/08/14
 * Time: 16:43
 * Write a PHP script InformationTable.php which generates an HTML table by given information about a person (name, phone number, age, address). Styling the table is optional. Semantic HTML is required
 */

function informationTable($Information){
$arr = explode("\r\n", $Information);

echo '<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <link rel="stylesheet" href="style.css">
	<title>Information Table</title>
</head>
<body>
<table >
    <tr>
        <th>Name</th>
        <td>'.$arr[0].'</td>
    </tr>
    <tr>
        <th>Phone Number</th>
        <td>'.$arr[1].'</td>
    </tr>
    <tr>
        <th>Age</th>
        <td>'.$arr[2].'</td>
    </tr>
    <tr>
        <th>Adress</th>
        <td>'.$arr[3].'</td>
    </tr>
</table>
</body>
</html>';

}
informationTable('Gosho
0882-321-423
24
Hadji Dimitar
');
?>
