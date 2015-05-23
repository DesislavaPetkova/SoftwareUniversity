<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 01:25
 */
?>




<table class="table table-striped table-hover ">
    <thead>
    <tr>
        <th><h2>Articles</h2></th>
    </tr>
    <tr>
    <?php if($this->isLoggedIn) : ?>
        <th><a href="/posts/create" class="btn btn-success">Create</a></th>
    <?php endif;?>
    </tr>
    </thead>
    <tbody>
    <?php foreach ($this->posts as $post): ?>
        <tr class="danger">
            <td><b><a href="/posts/article/<?php echo $post[0] ?>"><?php echo $post[1] ?></a></b></td>
            <td><?php echo $post[2] ?></td>
        </tr>
    <?php endforeach; ?>

    </tbody>
</table>

<ul class="pager">
    <li><a href="/posts/index/<?= $this->page - 1?>/<?= $this->pageSize ?>">Previous</a></li>
    <li><a href="/posts/index/<?= $this->page + 1?>/<?= $this->pageSize ?>">Next</a></li>
</ul>