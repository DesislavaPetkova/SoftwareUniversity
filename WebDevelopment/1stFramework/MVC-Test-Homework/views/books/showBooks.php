<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 09/05/2015
 * Time: 18:05
 */
?>

<div>
    <ul>
        <?php foreach ($this->books as $book) :?>
            <li>
                <?php echo $book[0]?>
            </li>
        <?php endforeach?>
    </ul>
</div>