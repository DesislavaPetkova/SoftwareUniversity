<?php

if (isset ($_POST['amount']) && isset($_POST['interest'])){
    $amount = $_POST['amount'];
  $interest = (integer)($_POST['interest']/12)/100;
   $period = $_POST['period'];
    $result = 0;
    $currency;
    switch ($_POST['currency']){
        case 1:
            $currency = '$';
            break;
        case 2:
            $currency = '&#8364;';
            break;
        case 3:
            $currency = "BGN";
            break;
    };
    for ($i = 0; $i < $period; $i++) {
      $amount += $amount*$interest;
    }
        $result=round($amount, 2);
}
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Calculate Interest</title>	

</head>
<body>
	<form method="POST" action="">
		<label for="amount">Enter Amount</label>
		<input type="text" id="amount" name="amount"><br>
		<input type="radio" name="currency" value="1">USD
		<input type="radio" name="currency" value="2">EUR
		<input type="radio" name="currency" value="3">BGN<br>
		<label for="interest">Compound Interest Amount</label>
		<input type="text" name="interest" id="interest"><br>
		<select name="period" id="period">
			<option value="6">6 Months</option>
			<option value="12">1 Year</option>
			<option value="24">2 Years</option>
			<option value="60">5 Years</option>
		</select>
		<input type="submit" name="submit" value="Calculate">
        <?php
            echo($currency." ".$result);
        ?>

	</form>
</body>
</html>