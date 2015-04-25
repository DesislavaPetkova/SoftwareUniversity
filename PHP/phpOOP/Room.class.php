<?php
/**
 * Created by PhpStorm.
 * User: ***
 * Date: 19/10/14
 * Time: 18:39
 */

namespace Hotel;
require_once("iReservable.class.php");

class Room implements iReservable{


    protected $Reservations = [];
    protected $roomType;
    protected $restroom;
    protected $balcony;
    protected $bedCount;
    protected $roomNum;
    protected $extras;
    protected $price;

    function __construct($balcony, $bedCount, $extras, $price, $restroom, $roomNum, $roomType)
    {
        $this->balcony = $balcony;
        $this->bedCount = $bedCount;
        $this->extras = $extras;
        $this->price = $price;
        $this->restroom = $restroom;
        $this->roomNum = $roomNum;
        $this->roomType = $roomType;
    }


    /**
     * @param mixed $bedCount
     */
    public function setBedCount($bedCount)
    {
        $this->bedCount = $bedCount;
    }

    /**
     * @return mixed
     */
    public function getBedCount()
    {
        return $this->bedCount;
    }

    /**
     * @param mixed $extras
     */
    public function setExtras($extras)
    {
        $this->extras = $extras;
    }

    /**
     * @return mixed
     */
    public function getExtras()
    {
        return $this->extras;
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

    /**
     * @param mixed $restroom
     */
    public function setRestroom($restroom)
    {
        $this->restroom = $restroom;
    }

    /**
     * @return mixed
     */
    public function getRestroom()
    {
        return $this->restroom;
    }

    /**
     * @param mixed $roomNum
     */
    public function setRoomNum($roomNum)
    {
        $this->roomNum = $roomNum;
    }

    /**
     * @return mixed
     */
    public function getRoomNum()
    {
        return $this->roomNum;
    }


    public function setRoomType($roomType)
    {
        if($this->roomType ==1){
            $this->roomType = "Standart";
        }

    }

    /**
     * @return mixed
     */
    public function getRoomType()
    {

        return $this->roomType;

    }

    /**
     * @param mixed $balcony
     */
    public function setBalcony($balcony)
    {
        $this->balcony = $balcony;
    }

    /**
     * @return mixed
     */
    public function getBalcony()
    {
        return $this->balcony;
    }

    function addReservation($reservation)
    {
        if(in_array($reservation, $this->Reservations)){
            throw new EReservationException();
        }else{
            $this->Reservations[] = $reservation;
        }
    }

    function removeReservation($reservation)
    {
        if(in_array($reservation, $this->Reservations)){
            $this->Reservations[] = "blank";
        }else{
            throw new EReservationException();
        }
    }


}