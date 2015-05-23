<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 01:19
 */
class PostsModel extends BaseModel{
    public function getAll(){
        $statement = self::$db->query("SELECT id,title, text FROM posts");
        $result = $statement->fetch_all();
        return $result;
    }

    public function getFilteredPosts($from, $size){
        $statement = self::$db->prepare("SELECT id,title, text FROM posts LIMIT ?, ?");
        $statement->bind_param("ii",$from, $size);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }

    public function createPost($title, $text) {
        if ($title == '') {
            return false;
        }
        $statement = self::$db->prepare(
            "INSERT INTO blog.posts(title, text) VALUES (?, ?);");
        $statement->bind_param("ss", $title, $text);
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

    public function showArticle($id){
        $statement = self::$db->prepare("SELECT id,title,text FROM blog.posts WHERE id = ?");
        $statement->bind_param("i",$id);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }
}