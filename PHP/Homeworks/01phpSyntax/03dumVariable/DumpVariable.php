<!--Write a PHP script DumpVariable.php that declares a variable. If the variable is numeric, print it by the built-in function var_dump(). If the variable is not numeric, print its type at the input.-->

<?php
function dumpVariable($a){
    if (is_numeric($a)){
        var_dump($a);
    } else {
     echo gettype($a);
    }
}
dumpVariable(1.234);
?>
