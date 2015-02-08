<?php
/**
 * Created by PhpStorm.
 * User: 23we
 * Date: 21/10/14
 * Time: 14:52
 */

namespace Hotel;
require_once('Guest.class.php');

class Reservation{
    private $startDate;
    private $endDate;
    private $guest;

    function __construct($startDate, $endDate, Guest $guest)
    {
        $this->startDate = $startDate;
        $this->endDate = $endDate;
        $this->guest = $guest;
    }

    /**
     * @param mixed $endDate
     */
    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }

    /**
     * @return mixed
     */
    public function getEndDate()
    {
        return $this->endDate;
    }

    /**
     * @param mixed $startDate
     */
    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    /**
     * @return mixed
     */
    public function getStartDate()
    {
        return $this->startDate;
    }

    function __toString()
    {
        return "From ".$this->startDate ." To ". $this->endDate." ".$this->guest;


    }


} 