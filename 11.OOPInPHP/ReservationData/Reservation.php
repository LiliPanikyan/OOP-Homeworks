<?php

namespace ReservationData {

    use GuestData\Guest;
    use InvalidArgumentException;

    class Reservation {
        protected  $startDate;
        protected  $endDate;

        function __construct($startDate, $endDate , Guest $guest)
        {
            $this->setStartDate($startDate);
            $this->setEndDate($endDate);
            $this->setGuest($guest);
        }

        public function getStartDate()
        {
            return $this->startDate;
        }

        public function setStartDate($startDate)
        {

            $this->startDate = $startDate;
        }

        public function getEndDate()
        {
            return $this->endDate;
        }

        public function setEndDate($endDate)
        {
            if(strtotime($this->getStartDate())>=strtotime($endDate)) {
                throw new InvalidArgumentException("Invalid data!");
            }
            $this->endDate = $endDate;
        }

        public function getGuest()
        {
            return $this->guest;
        }

        public function setGuest(Guest $guest)
        {
            $this->guest = $guest;
        }

        public  function  calculateBookedPeriod()
        {
            $start = strtotime($this->startDate);
            $end = strtotime($this->endDate);
            $bookPeriod = ceil(abs($end - $start) / 86400);
            return $bookPeriod;
        }
    }
}