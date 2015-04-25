<?php 
function numberSum($a, $b){
$firstNum = $a;
$secondNum = $b;
$result = round($firstNum + $secondNum, 2);
echo '$firstNumber + $secondNumber = '.$firstNum.' + '.$secondNum.' = '.$result;
}
numberSum(1.567808, 0.356);
?>