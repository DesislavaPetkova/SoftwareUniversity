<?php
/**
 * Created by PhpStorm.
 * User: 23232
 * Date: 21/10/14
 * Time: 15:25
 */

namespace Hotel;


interface iReservable {

    function addReservation($reservation);
    function removeReservation($reservation);
} 