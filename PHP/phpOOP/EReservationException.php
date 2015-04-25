<?php
/**
 * Created by PhpStorm.
 * User: qwewe
 * Date: 21/10/14
 * Time: 15:28
 */

namespace Hotel;


class EReservationException extends \Exception{

    public function __construct() {
        parent::__construct("There is such reservation already", 101);
    }

} 