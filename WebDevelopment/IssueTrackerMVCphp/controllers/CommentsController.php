<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 11:40
 */
class CommentsController extends BaseController{
    private $db;
    public $comments;
    public function onInit() {
        $this->title = "Comments";
        $this->db = new CommentsModel();
    }

    public function index(){
        $this->renderView("createComment");
    }

    public function showComments($postId){
        $this->comments = $this->db->showComments($postId);
        $this->renderView("showComments", false);
        return $this->comments;
    }

    public function createComment($postId = null)
    {
        $this->renderView(__FUNCTION__);

        $nick =  isset($_POST['nickname']) ? $_POST['nickname'] : '';
        $comment = isset($_POST['comment']) ? $_POST['comment'] : '';


        if ($this->db->addComment($nick, $comment, $postId)) {
            $this->addInfoMessage("Comment created.");
        } else {
            $this->addErrorMessage("Error creating Comment.");
        }

    }

}


