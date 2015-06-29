<table class="table table-striped table-hover ">
    <thead>
    <tr>
        <th><h2>Issues for tracking</h2></th>
    </tr>
    <tr>
        <?php if($this->isLoggedIn) : ?>
            <th><a href="/issues/create" class="btn btn-success">Create</a></th>
        <?php endif;?>
    </tr>
    </thead>
    <tbody id="danger">
    <?php
    //var_dump($this->issues);

    ?>

    <?php foreach ($this->issues as $issue): ?>
        <tr class="danger" >
            <td><b><a href="/issues/issue/<?php echo htmlspecialchars($issue[0]) ?>"><?php echo htmlspecialchars
                        ($issue[1])
                        ?></a></b></td>
            <td><b> State: <?php echo htmlspecialchars($issue[3]) ?></b></td>
            <td><?php echo $issue[2] ?></td>
            <td><i><?php echo date('d-F-Y h:i:s',strtotime($issue[4]))?></i></td>
            <td><i>Posted By: <?php echo htmlspecialchars($issue[5])?></i></td>

        </tr>

    <?php endforeach; ?>

    </tbody>
</table>

