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

        <div class="btn-group">
            <a href="#" class="btn btn-default">State</a>
            <a href="#" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-expanded="true"><span class="caret"></span></a>
            <ul class="dropdown-menu">
                <li><a href="#">New</a></li>
                <li><a href="#">Open</a></li>
                <li><a href="#">Fixed</a></li>
                <li><a href="#">Closed</a></li>
                <li class="divider"></li>
                <li><a href="#">Separated link</a></li>
            </ul>
        </div>

        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="reset" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-primary">Edit</button>
            </div>
        </div>
    </fieldset>
</form>