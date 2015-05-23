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
        <legend>Create Post</legend>
        <div class="form-group">
            <label for="title" class="col-lg-2 control-label">Title</label>
            <div class="col-lg-10">
                <input name="title" type="text" class="form-control" id="title" placeholder="Title">
            </div>
        </div>
        <div class="form-group">
            <label for="content" class="col-lg-2 control-label">Content</label>
            <div class="col-lg-10">
                <textarea name="content"  class="form-control" id="content" placeholder="Add some text
                here"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label for="tags" class="col-lg-2 control-label">Tags</label>
            <div class="col-lg-10">
                <input name="tags" type="text" class="form-control" id="tags" placeholder="Tags">
            </div>
        </div>
        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="reset" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-primary">Create</button>
            </div>
        </div>
    </fieldset>
</form>