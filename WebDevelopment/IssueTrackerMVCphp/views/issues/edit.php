<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 09:09
 */
?>

<form class="form-horizontal" action="" method="POST">
    <fieldset>
        <legend>Edit Issue</legend>
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

        <div class="form-group">
            <label for="select" class="col-lg-2 control-label">Selects</label>
            <div class="col-lg-10">
                <select class="form-control" id="select" name="state">
                    <option>New</option>
                    <option>Open</option>
                    <option>Fixed</option>
                    <option>Closed</option>
                </select>
            </div>
        <div class="form-group" style="margin: 2%">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="reset" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-primary">Edit</button>
            </div>
        </div>
    </fieldset>
</form>