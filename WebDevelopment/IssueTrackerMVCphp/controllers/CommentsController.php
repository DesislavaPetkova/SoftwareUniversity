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

    public function showComments($issueId){
        $this->comments = $this->db->showComments($issueId);
        $this->renderView("showComments", false);
        return $this->comments;
    }

    public function createComment($issueId)
    {
        if($this->isPost){
            $nick =  isset($_POST['nickname']) ? $_POST['nickname'] : '';
            $comment = isset($_POST['text']) ? $_POST['text'] : '';


            if ($this->db->addComment($comment, $nick, $issueId)) {
                $this->addInfoMessage("Comment created.");
            } else {
                $this->addErrorMessage("Error creating Comment.");
            }
        }
        $this->renderView(__FUNCTION__);

    }

}


