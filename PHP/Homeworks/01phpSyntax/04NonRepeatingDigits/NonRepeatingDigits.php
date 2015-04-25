<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 13/08/14
 * Time: 12:08
 * Write a PHP script NonRepeatingDigits.php that declares an integer variable N, and then finds all 3-digit numbers that are less or equal than N (<= N) and consist of unique digits. Print "no" if no such numbers exist.
 */

function NonRepeatingDigits($a){
    $arr = array();
    if(strlen($a)<3){
        echo "no";
        return;
    }
    for ($i=100; $i<=$a; $i++){
        $string =(string)$i;
        $check1 = substr($string, 0, 1);
        $check2 = substr($string, 1, 1);
        $check3 = substr($string, 2, 1);
        if(strlen($i)>3){
            break;
        }
        if ($check1!= $check2 && $check2!= $check3 && $check3!= $check1){
            array_push($arr, $i);
        }else {
            continue;
        }

    }
    echo implode(', ', $arr);

}
NonRepeatingDigits(1234);
?>