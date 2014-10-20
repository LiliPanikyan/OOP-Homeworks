<?php

namespace RoomData {

    require_once "iReservable.php";
    use InvalidArgumentException;
    use iReservable;
    use OutOfRangeException;
    use ReservationData\Reservation;

    class RoomType {
        const Standard = "Standart";
        const Gold = "Gold";
        const Diamond = "Diamond";
    }

    abstract class Room implements iReservable{

        protected $roomNumber;
        protected $price;
        protected  $reservations = [];

        function __construct($roomNumber, $price)
        {
            $this->setRoomNumber($roomNumber);
            $this->setPrice($price);
        }

        public function getRoomNumber()
        {
            return $this->roomNumber;
        }

        public function setRoomNumber($roomNumber)
        {
            if($roomNumber <100 || $roomNumber > 1099) {
                throw new OutOfRangeException("Room number should be [100....1099]");
            }
            $this->roomNumber = $roomNumber;
        }

        public function getPrice()
        {
            return $this->price;
        }

        public function setPrice($price)
        {
            if($price < 99 || $price > 3599) {
                throw new OutOfRangeException("Room prices are in range [99....3599]");
            }
            $this->price = $price;
        }

        public function setReservations($reservations)
        {
            $this->reservations[] = $reservations;
        }

        public function getReservations()
        {
            return $this->reservations;
        }

        public function removeReservation(Reservation $reservation)
        {
            if(($key = array_search($reservation, $this->reservations)) !== false) {
                unset($this->reservations[$key]);
            } else {
                throw new InvalidArgumentException("There is no such reservation.");
            }
        }

        public function addReservation(Reservation $reservation)
        {

            if (empty($this->reservations)) {
                $this->reservations[]=$reservation;
            } else {
                foreach ($this->reservations as $existingReservation) {

                    if ((strtotime($reservation->getStartDate())) >= (strtotime($existingReservation->getStartDate())) &&
                            (strtotime($reservation->getEndDate())) <= (strtotime($existingReservation->getEndDate()))) {

                        throw new InvalidArgumentException(
                            "Sorry, room " . $this->roomNumber . " is not available for this period");

                        /**
                         * if the date of release of the new reservation overlaps with existing booking
                         */
                    } elseif ((strtotime($reservation->getStartDate())) <= (strtotime($existingReservation->getStartDate())) &&
                        (strtotime($reservation->getEndDate())) <= (strtotime($existingReservation->getEndDate())) &&
                        (strtotime($reservation->getEndDate()))>= (strtotime($existingReservation->getStartDate()))) {

                        throw new InvalidArgumentException(
                            "Sorry, your release date overlaps with existing booking.
                            You have to release the room before ".$existingReservation->getStartDate());

                        /**
                         * if the start date of the new reservation overlaps with existing booking
                         */
                    } elseif ((strtotime($reservation->getStartDate())) >= (strtotime($existingReservation->getStartDate())) &&
                        (strtotime($reservation->getEndDate())) >= (strtotime($existingReservation->getStartDate())) &&
                        (strtotime($reservation->getStartDate())) <= (strtotime($existingReservation->getEndDate()))) {

                        throw new InvalidArgumentException(
                            "Sorry, your start date overlaps with existing booking.
                            Room is available after ". $existingReservation->getEndDate());

                    } else {
                        array_push($this->reservations, $reservation);
                    }
                }
            }
        }

        public abstract function getRoomType();

        public abstract function getRestroom();

        public abstract function getBedCount();

        public abstract function getHasBalcony();

        public abstract function getExtras();

        public abstract function getRoomInfo();

        function __toString()
        {
            $output = $this->getRoomType()."\r\n";
            $output .= "Restroom: $this->getRestroom()\r\n";
            $output .= "Beds: $this->getBedCount()\r\n";
            $output .= "Balcony: $this->getHasBalcony()\r\n";
            $output .= "Extras: ".json_encode($this->getExtras())."\r\n";
            return $output;
        }
    }
}