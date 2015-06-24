<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 09:09
 */
?>

<form class="form-horizontal" action="create" method="POST">
    <fieldset>
        <legend>Create Issue</legend>
        <div class="form-group">
            <label for="title" class="col-lg-2 control-label">Title</label>
            <div class="col-lg-10">
                <input name="title" type="text" class="form-control" id="title" placeholder="Title">
            </div>
        </div>
        <div class="form-group">
            <label for="description" class="col-lg-2 control-label">Description</label>
            <div class="col-lg-10">
                <textarea name="description"  class="form-control" id="description" placeholder="Add some text
                here"></textarea>
            </div>
        </div>
<!--        --><?php
//        var_dump($_SESSION)
//        ?>

<!--        <div class="form-group">-->
<!--            <label for="tags" class="col-lg-2 control-label">Tags</label>-->
<!--            <div class="col-lg-10">-->
<!--                <input name="tags" type="text" class="form-control" id="tags" placeholder="Tags">-->
<!--            </div>-->
<!--        </div>-->
        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="reset" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-primary">Create</button>
            </div>
        </div>
    </fieldset>
</form>