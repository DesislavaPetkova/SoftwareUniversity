<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 00:30
 */
?>


<form class="form-horizontal" action="register" method="POST">
    <fieldset>
        <legend>Register</legend>
        <div class="form-group">
            <label for="username" class="col-lg-2 control-label">Username</label>
            <div class="col-lg-10">
                <input name="username" type="text" class="form-control" id="username" placeholder="Username">
            </div>
        </div>
        <div class="form-group">
            <label for="password" class="col-lg-2 control-label">Password</label>
            <div class="col-lg-10">
                <input name="password" type="password" class="form-control" id="password" placeholder="Password">

            </div>
        </div>

        <div class="form-group">
            <div class="col-lg-10 col-lg-offset-2">
                <button type="reset" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-primary">Register</button>
            </div>
        </div>
    </fieldset>
</form>

