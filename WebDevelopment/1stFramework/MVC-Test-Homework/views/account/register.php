<php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 09/05/2015
 * Time: 13:03
 */
?>
<h1>Register</h1>
<form action="register" method="POST">
    <label for="username">Username:</label>
    <input type="text" name="username" id="username"/>
    <br/>
    <label for="password">Password:</label>
    <input type="password" name="password" id="password"/>
    <br/>
    <input type="submit" value="Register"/>
    <a href="/account/login">Login</a>
</form>