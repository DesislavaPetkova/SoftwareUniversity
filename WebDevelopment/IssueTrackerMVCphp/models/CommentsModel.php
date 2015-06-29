<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 11:42
 */
class CommentsModel extends BaseModel{
    public function getAll(){
        $statement = self::$db->query("SELECT text,name, postId FROM blog.comments");
        $result = $statement->fetch_all();
        return $result;
    }

    public function addComment($comment, $nick, $issueId) {
        if ($nick == '') {
            return false;
        }
        if ($issueId == 0 ) {
            return false;
        }
        $statement = self::$db->prepare(
            "INSERT INTO blog.comments(text, name, postId) VALUES (?, ?, ?)");
        $statement->bind_param("ssi", $comment, $nick, $issueId);
        $statement->execute();
        return true;
    }

    public function showComments($postId) {
        if ($postId == '') {
            return false;
        }

        $statement = self::$db->prepare("SELECT  text, name FROM blog.comments WHERE postId = ?;");
        $statement->bind_param("i", $postId);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }
}