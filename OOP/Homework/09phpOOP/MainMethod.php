<?php
namespace Hotel;

require_once("SingleRoom.class.php");
require_once("Room.class.php");
require_once("RoomType.class.php");
require_once("Bedroom.class.php");
require_once("Apartment.class.php");
require_once("Guest.class.php");
require_once("Reservation.class.php");
require_once("BookingManager.php");
require_once("EReservationException.php");

$firstRoom = new SingleRoom(123,99);
$room2 = new Bedroom(321, 199);
$apart = new Apartment(413, 299);
echo($firstRoom);
echo("\n\r");
echo($room2. "\n\r");
echo($apart);

$guestOne = new Guest("Ivaylo", "Iliev", 23432354);

echo("\n\r".$guestOne);

$reservationOne = new Reservation("21-10-2014", "31-20-2014", $guestOne);

echo("\n\r".$reservationOne);
echo("\n\r");
BookingManager::bookRoom($room2, $reservationOne);
BookingManager::bookRoom($room2, $reservationOne);

$firstQuest = new Guest("Georgi", "Dimitrov", 12548789);
$secondQuest = new Guest("Todor", "Jivkov", 2165418);
$thirdQuest = new Guest("Georgi", "Parvanov", 89466466);


$firstReservation = new Reservation("19-10-2014", "21-10-2014", $firstQuest);
$secondReservation = new Reservation("20-10-2014", "25-10-2014", $secondQuest);
$thirdReservation = new Reservation("18-10-2014", "26-10-2014", $thirdQuest);
$fourReservation = new Reservation("01-10-2014", "17-10-2014", $thirdQuest);

$roomOne = new SingleRoom(501, 99);
$roomTwo = new Bedroom(632, 250);
$roomThree = new Apartment(123, 299);

BookingManager::bookRoom($roomOne, $firstReservation);
BookingManager::bookRoom($roomTwo,$secondReservation);
BookingManager::bookRoom($roomThree,$thirdReservation);
BookingManager::bookRoom($roomTwo, $fourReservation);

$roomsArray =[$roomTwo, $roomOne, $roomThree, $room2];


$firstSort = array_filter($roomsArray, function(Room $n){
   return ($n->getRoomType() =="Gold"||$n->getRoomType()=="Diamond")&&($n->getPrice()>=250);
});
var_dump($firstSort);

$secondSort = array_filter($roomsArray, function(Room $b){
  return $b->getBalcony() == 1;
});

var_dump($secondSort);


