<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 12:07
 */
?>
<?php foreach ($this->comments as $comment) :?>
<table class="table table-striped table-hover" id="comments">
    <thead>
    <tr>
        <th><?php echo $comment[1] . " said: "?></th>
    </tr>
    </thead>
    <tbody>

    <tr class="warning">
            <td>
                <?php echo $comment[0]?>
    </tr>
    </tbody>
</table>
<?php endforeach?>