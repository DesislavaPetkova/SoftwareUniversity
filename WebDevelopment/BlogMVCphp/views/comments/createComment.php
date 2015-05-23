<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 13:00
 */

?>

<form id="addcomments" class="form-control-static" action="/comments/createComment"
      method="POST">
    <fieldset>
        <legend>Create Comment</legend>
        <div class="form-group">
            <label for="nickname" class="col-lg-2 control-label">NickName</label>
            <div class="col-lg-10">
                <input name="nickname" type="text" class="form-control" id="nickname" placeholder="NickName">
            </div>
        </div>
        <div class="form-group">
            <label for="text" class="col-lg-2 control-label">Comment</label>
            <div class="col-lg-10">
                <textarea name="text"  class="form-control" id="text" placeholder="Add some text
                here"></textarea>
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