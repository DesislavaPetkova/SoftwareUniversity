<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 09:47
 */
//var_dump($this->postId);
?>


<table class="table table-striped table-hover ">
    <thead>
    <tr>
        <th><h2><?php echo $this->issue[0][1]?></h2></th>
    </tr>
    </thead>
    <tbody>
        <tr class="danger">
            <td><b><?php echo $this->issue[0][2] ?></b></td>
        </tr>
    </tbody>
</table>
<button id="show-comments" class="btn btn-success">Show Comments</button>
<a href="/../comments/createComment/<?php echo $this->issue[0][0]?>" id="add-comments" class="btn btn-success">Add
    Comments</a>
<a href="/../issues/editIssue/" id="edit" class="btn
btn-success">Edit</a>
<script>
    $('#show-comments').on('click', function(ev){
        $.ajax({
            url: '/comments/showComments/<?php echo $this->issue[0][0]?>',
            method: 'GET'

        }).success(function(data){
            $('#comments').html(data);
        })
    });

</script>

<table class="table table-striped table-hover" id="comments">

</table>
<table class="table table-striped table-hover" id="addcomments">

</table>

