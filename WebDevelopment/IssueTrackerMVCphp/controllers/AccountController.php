<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 00:22
 */
class AccountController extends BaseController{

    private $db;

    public function onInit(){
        $this->db = new AccountModel();
    }

    public function register(){
        if($this->isPost){

            $username = $_POST["username"];
            if($username == null || strlen($username)< 3){
                $this->addErrorMessage("username is invalid");
                $this->redirect("account", "register");
            }
            $password = $_POST["password"];
            $isRegistered = $this->db->register($username, $password);
            if($isRegistered){
                $_SESSION["username"] = $username;
                $this->addInfoMessage("Successful registration!");
                $this->redirect("home", "index");
            }else{
                $this->addErrorMessage("Register failed");
            }
        }

        $this->renderView(__FUNCTION__);
    }
    public function login(){
        if($this->isPost){
            $username = $_POST['username'];
            $password = $_POST['password'];
            $isLoggedIn = $this->db->login($username, $password);
            if($isLoggedIn){
                $_SESSION["username"] = $username;
                $this->addInfoMessage("Logged successful");
                $this->redirect("issues", 'index');
                return;
            }else{
                $this->addErrorMessage("Login failed!");

            }
        }
        $this->renderView(__FUNCTION__);
    }
    public function logout(){
        $this->Authorize();
        unset($_SESSION["username"]);
        $this->addInfoMessage("Logged out!");

        $this->redirectToUrl("/");
    }
}