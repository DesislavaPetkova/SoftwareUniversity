<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 01:18
 */

class PostsController extends BaseController {
    private $db;

    public function onInit() {
        $this->title = "Posts";
        $this->db = new PostsModel();
    }

    public function index($page = 0, $pageSize = 3) {
//        $this->Authorize();

        $from = $page * $pageSize;
        $this->page = $page;
        $this->pageSize = $pageSize;

        $this->posts = $this->db->getFilteredPosts($from, $pageSize);

        $this->renderView();
    }

    public function showPosts(){
        $this->posts = $this->db->getAll();
        $this->renderView(__FUNCTION__, false);
    }

    public function create(){
        $this->Authorize();
        if ($this->isPost) {
            $title = $_POST['title'];
            $content = $_POST['content'];
            if(strlen($title) < 3){
                $this->addFieldValue('title', $title);
                $this->addValidationError('title', 'The title name length should be grater than 2');
                return $this->renderView(__FUNCTION__);
            }

            if ($this->db->createPost($title, $content)) {
                $this->addInfoMessage("Post created.");
                $this->redirect('posts');
            } else {
                $this->addErrorMessage("Error creating author.");
            }
        }
        $this->renderView(__FUNCTION__);
    }

    public function article($id){
        $this->article = $this->db->showArticle($id);
        $this->postId = $id;
        $this->renderView("article");
    }

}