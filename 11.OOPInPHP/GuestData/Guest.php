<?php

namespace GuestData {

    class Guest {
        protected  $firstName;
        protected $lastName;
        protected $guestIDNumber;

        function __construct($firstName, $lastName, $guestIDNumber)
        {
            $this->setFirstName($firstName);
            $this->setLastName($lastName);
            $this->setGuestIDNumber($guestIDNumber);
        }

        public function getFirstName()
        {
            return $this->firstName;
        }
        public function setFirstName($firstName)
        {
            $this->validateUserName($firstName);
            $this->firstName = $firstName;
        }

        public function getLastName()
        {
            return $this->lastName;
        }
        public function setLastName($lastName)
        {
            $this->validateUserName($lastName);
            $this->lastName = $lastName;
        }

        public function getGuestIDNumber()
        {
            return $this->guestIDNumber;
        }
        public function setGuestIDNumber($guestIDNumber)
        {
            $this->validateUserID($guestIDNumber);
            $this->guestIDNumber = $guestIDNumber;
        }

        public function validateUserName($value)
        {
            if ($value == "" || strlen($value) < 3) {
                throw new InvalidArgumentException ("Invalid or empty input value!");
            }
        }

        public function validateUserID($guestIDNumber)
        {
            if (strlen($guestIDNumber) != 10) {
                throw new InvalidArgumentException ("Invalid or empty ID number! Please enter 10 digit number.");
            }
        }
    }
}