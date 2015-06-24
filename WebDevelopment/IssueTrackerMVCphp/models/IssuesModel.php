<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 01:19
 */
class IssuesModel extends BaseModel{
    public function getAll(){
        $statement = self::$db->query("SELECT id,title,state,date text FROM issues");
        $result = $statement->fetch_all();
        return $result;

    }

    public function getFilteredIssues($from, $size){
        $statement = self::$db->prepare("SELECT id,title,description, state, postedDate, author FROM issues ORDER BY postedDate  DESC LIMIT ?,?");
        $statement->bind_param("ii",$from, $size);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }

    public function createIssue($title, $text) {
        if ($title == '') {
            return false;
        }
        $state = 'New';
        $currentUser = $_SESSION['username'];
        $idStatement = self::$db->query("SELECT id FROM users WHERE username LIKE ". "'".$currentUser."'");
        //$idStatement->bind_param('s', $currentUser);
        $result = $idStatement->fetch_all();
        //$userId = $result[0][0];
        $date = date("Y-m-d H:i:s");
        $statement = self::$db->prepare(
            "INSERT INTO blog.issues(title, description, author, state, postedDate) VALUES (?, ?, ?, ?, ?)");
        $statement->bind_param("sssss", $title, $text, $currentUser, $state, $date);
        $statement->execute();
        return $statement->affected_rows > 0;
    }

    public function deletePost($id) {
        $statement = self::$db->prepare(
            "DELETE FROM authors WHERE id = ?");
        $statement->bind_param("i", $id);
        $statement->execute();
        return $statement->affected_rows > 0;
    }

    public function showIssue($id){
        $statement = self::$db->prepare("SELECT id,title,description FROM blog.issues WHERE id = ?");
        $statement->bind_param("i",$id);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }
}