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

    public function addComment($nickName, $text, $postId) {
        if ($nickName == '') {
            return false;
        }
        if ($postId == 0 ) {
            return false;
        }
        $statement = self::$db->prepare(
            "INSERT INTO blog.comments(nickName, text, postId) VALUES (?, ?, ?);");
        $statement->bind_param("ssi", $nickName, $text, $postId);
        $statement->execute();
        return true;
    }

    public function showComments($postId) {
        if ($postId == '') {
            return false;
        }

        $statement = self::$db->prepare("SELECT  text,name FROM blog.comments WHERE postId = ?;");
        $statement->bind_param("i", $postId);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }
}