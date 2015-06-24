<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 01:18
 */

class IssuesController extends BaseController {
    private $db;

    public function onInit() {
        $this->title = "Issues";
        $this->db = new IssuesModel();
    }

    public function index($page = 0, $pageSize = 3) {
//        $this->Authorize();

        $from = $page * $pageSize;
        $this->page = $page;
        $this->pageSize = $pageSize;

        $this->issues = $this->db->getFilteredIssues($from, $pageSize);

        $this->renderView();
    }

    public function showIssues(){
        $this->issues = $this->db->getAll();
        $this->renderView(__FUNCTION__, false);
    }

    public function create(){
        $this->Authorize();
        if ($this->isPost) {
            $title = $_POST['title'];
            $description = $_POST['description'];
            if(strlen($title) < 3){
                $this->addFieldValue('title', $title);
                $this->addValidationError('title', 'The title name length should be grater than 2');
                return $this->renderView(__FUNCTION__);
            }

            if ($this->db->createIssue($title, $description)) {
                $this->addInfoMessage("Issue created.");
                $this->redirect('issues');
            } else {
                $this->addErrorMessage("Error creating author.");
            }
        }
        $this->renderView(__FUNCTION__);
    }

    public function issue($id){
        $this->issue = $this->db->showIssue($id);
        $this->issueId = $id;
        $this->renderView("issue");
    }

    public function editIssue($id){
        $this->Authorize();

        if ($this->isPost) {
            $title = $_POST['title'];
            $description = $_POST['description'];
            $state = $_POST['state'];
            if(strlen($title) < 3){
                $this->addFieldValue('title', $title);
                $this->addValidationError('title', 'The title name length should be grater than 2');
                return $this->renderView(__FUNCTION__);
            }

            if ($this->db->updateIssue($title, $description, $state)) {
                $this->addInfoMessage("Issue updated.");
                $this->redirect('issues');
            } else {
                $this->addErrorMessage("Error editing issue.");
            }
        }
        $this->renderView(__FUNCTION__);

    }

}