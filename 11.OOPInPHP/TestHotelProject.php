<?php
function __autoload($className)
{
    include_once("./" . $className . ".php");
}

    $ivan = new \GuestData\Guest("Ivan", "Borisov", 8080808080);
    $ivanReservation = new \ReservationData\Reservation("01-11-2014", "05-11-2014", $ivan);
    $singleRoom = new \RoomData\SingleRoom(333, 105);
    /**
     * Test rooms and functions
     */
    //echo $singleRoom;
    //$singleRoom->addReservation($ivanReservation);

    //$maria = new Guest("Maria", "Ivanova", 7070707070);
    //$mariaReservation = new Reservation("10-10-2014", "12-10-2014", $maria);
    //$singleRoom->addReservation($mariaReservation);

    //print_r($singleRoom);

    //$singleRoom->removeReservation($mariaReservation);
    //print_r($singleRoom);

    $doubleRoomFifthFloor = new \RoomData\Bedroom(555, 205);
    $bobi = new \GuestData\Guest("Bobi", "Borisov", 1234567891);
    $bobiReservation = new \ReservationData\Reservation("25-12-2014", "02-01-2015", $bobi);
    //echo $doubleRoom;

    BookingManager::bookRoom($singleRoom, $ivanReservation);
    BookingManager::bookRoom($doubleRoomFifthFloor, $bobiReservation);

    $doubleRoomSixthFloor = new \RoomData\Bedroom(610, 255);
    $apartmentSixthFloor = new \RoomData\Apartment(666,400);
    $apartmentEightFloor = new \RoomData\Apartment(888, 640);

    $hotel = array(
        $singleRoom,
        $doubleRoomFifthFloor,
        $doubleRoomSixthFloor,
        $apartmentSixthFloor,
        $apartmentEightFloor);

    echo "////Sorted by price less or equal to 250\r\n";
    $filterByPrice = array_filter($hotel, function($room){
        return ($room->getRoomType()== "Gold" && $room->getPrice()<= 250 ||
            $room->getRoomType() == "Diamond" && $room->getPrice()<= 250);
    });
    var_dump($filterByPrice);

    echo "////Rooms with balcony\r\n";
    $filterByBalcony = array_filter($hotel, function($r){
        return $r->getHasBalcony() == "Yes";

    });
    var_dump($filterByBalcony);

    echo "////Rooms with bathtub\r\n";
    $filterByBathtub = array_filter($hotel, function($h){
        if(in_array('bathtub', $h->getExtras())) {
            return $h;
        }
    });
    foreach($filterByBathtub as $room) {
        echo $room->getRoomNumber()."\r\n";
    }

?>