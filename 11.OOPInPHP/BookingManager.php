<?php
use ReservationData\Reservation;
use RoomData\Room;

class BookingManager {
    static function bookRoom(Room $room, Reservation $reservation) {
           $room->addReservation($reservation);
                echo
                    "Room <strong>{$room->getRoomNumber()}</strong>"."successfully booked for <strong>
                    {$reservation->getGuest()->getFirstName()} {$reservation->getGuest()->getLastName()}</strong>".
                    " from <time>{$reservation->getStartDate()}</time> to <time>{$reservation->getEndDate()}</time>!\r\n";

    }
} 