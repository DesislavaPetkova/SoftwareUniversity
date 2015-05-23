<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 01:27
 */
?>
<div>
    <ul>
        <?php foreach ($this->posts as $post) :?>
            <li>
                <?php echo $post[0]?>
            </li>
        <?php endforeach?>
    </ul>
</div>