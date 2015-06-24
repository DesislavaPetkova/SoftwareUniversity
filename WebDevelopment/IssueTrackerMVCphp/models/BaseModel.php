<?php
/**
 * Created by PhpStorm.
 * User: Ivaylo.Il
 * Date: 10/05/2015
 * Time: 00:03
 */

abstract class BaseModel {
    protected static $db;

    public function __construct() {
        if (self::$db == null) {
            self::$db = new mysqli(
                DB_HOST, DB_USER, DB_PASS, DB_NAME);
            self::$db->set_charset("utf8");
            if (self::$db->connect_errno) {
                die('Cannot connect to database');
            }
        }
    }
}