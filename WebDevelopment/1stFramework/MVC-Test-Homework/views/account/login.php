<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 09/05/2015
 * Time: 15:21
 */
?>

<h1>Login</h1>
<form action="login" method="POST">
    <label for="username">Username:</label>
    <input type="text" name="username" id="username"/>
    <br/>
    <label for="password">Password:</label>
    <input type="password" name="password" id="password"/>
    <br/>
    <input type="submit" value="Login"/>
    <a href="/account/register">Register</a>
</form>