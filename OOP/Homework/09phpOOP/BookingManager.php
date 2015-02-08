<?php
/**
 * Created by PhpStorm.
 * User: qwewew
 * Date: 21/10/14
 * Time: 16:03
 */

namespace Hotel;
require_once("Room.class.php");

class BookingManager {

    static function bookRoom(Room $room, Reservation $reservation){
        try{
            $room->addReservation($reservation);
            echo("Room successfully booked"."\n\r");
        }catch (EReservationException $ex){
            echo PHP_EOL . $ex->getMessage();
        }

    }
} 