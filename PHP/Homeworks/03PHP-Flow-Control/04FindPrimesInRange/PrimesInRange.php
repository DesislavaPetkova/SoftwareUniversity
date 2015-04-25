<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 19/08/14
 * Time: 21:19
 * Write a PHP script PrimesInRange.php that receives two numbers – start and end – from an input field and displays all numbers in that range as a comma-separated list. Prime numbers should be bolded. Styling the page is optional.
 */
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
	<title>PrimesInRange</title>
</head>
<body>
<form action="<?php $_PHP_SELF; ?>" method="post">
    <label for="start">Starting Index: </label>
    <input type="text" name="start" id="start"/>
    <label for="end">End: </label>
    <input type="text" name="end" id="end" title="weqw wqe qwew q"/>
    <input type="submit" name="submit"/>
</form>
<?php
if (isset($_POST['submit'])){
    $start = htmlentities($_POST['start']);
    $end = htmlentities($_POST['end']);
    $arr;
    function isPrime(&$check){
        if($check == 2 || $check == 3 || $check == 5 || $check == 7){

            return true;
        }
        if($check > 1 && ($check % 2 != 0 && $check % 3 != 0 && $check % 5 != 0 && $check % 7 != 0)){
            return true;
        }
    }
//    $start =2;
//    $end = 18;
    for ($i = $start; $i <= $end; $i++) {
        $arr[]=$i;
    }
    for ($i = 0; $i < count($arr); $i++) {
        if(isPrime($arr[$i])){
            $arr[$i] = '<b>'.$arr[$i].'</b>';

        }
    }
    echo implode(', ', $arr);
    }






?>
</body>
</html>