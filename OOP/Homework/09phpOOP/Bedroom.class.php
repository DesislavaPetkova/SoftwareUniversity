<?php
/**
 * Created by PhpStorm.
 * User: ***
 * Date: 20/10/14
 * Time: 13:23
 */

namespace Hotel;
require_once("Room.class.php");

class Bedroom extends  Room{
    protected $number;
    protected $price;

    function __construct($number, $price)
    {
        parent::__construct(True, 2, "TV, air-conditioner, refrigerator, mini-bar, bathtub", null, true, null,
            RoomType::GOLD);
        $this->number = $number;
        $this->price = $price;
    }

    /**
     * @param mixed $number
     */
    public function setNumber($number)
    {
        $this->number = $number;
    }

    /**
     * @return mixed
     */
    public function getNumber()
    {
        return $this->number;
    }

    /**
     * @param mixed $price
     */
    public function setPrice($price)
    {
        $this->price = $price;
    }

    /**
     * @return mixed
     */
    public function getPrice()
    {
        return $this->price;
    }

    function __toString()
    {
        return "Single Room with No.:".$this->number." and price:".$this->price;
    }


}