<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 09/05/2015
 * Time: 17:45
 */

class BooksModel extends BaseModel{
    public function getAll(){
        $statement = self::$db->query("SELECT id,title FROM books");
        $result = $statement->fetch_all();
        return $result;
    }

    public function getFilteredBooks($from, $size){
        $statement = self::$db->prepare("SELECT id,title FROM books LIMIT ?, ?");
        $statement->bind_param("ii",$from, $size);
        $statement->execute();
        $result = $statement->get_result()->fetch_all();
        return $result;
    }

}