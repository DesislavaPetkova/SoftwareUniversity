<?php
/**
 * Created by PhpStorm.
 * User: wew.w
 * Date: 20/10/14
 * Time: 16:55
 */

namespace Hotel;
require_once "Room.class.php";

class SingleRoom extends Room{

    protected $roomNum;
    protected $price;

    function __construct($roomNum, $price)
    {
        parent::__construct(false, 1, "TV, air-conditioner, refrigerator, mini-bar, bathtub", null, true, null,
            RoomType::STANDART);
        $this->price = $price;
        $this->roomNum = $roomNum;
    }




    function __toString()
    {
        return "Single Room with No.:".$this->roomNum." and price:".$this->price;
    }


} 