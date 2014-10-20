<?php
/**
 * Created by PhpStorm.
 * User: Niki&Lili
 * Date: 14-10-19
 * Time: 18:59
 */

namespace RoomData {


    class SingleRoom extends Room{

        function __construct($roomNumber, $price)
        {
            parent::__construct($roomNumber, $price);
        }

        public function getRoomType()
        {
            $roomType = RoomType::Standard;
            return $roomType;
        }

        public function getRestroom()
        {
            $restroom = "Yes";
            return $restroom;
        }

        public function getHasBalcony()
        {
            $hasBalcony = 'No';
            return $hasBalcony;
        }

        public function getBedCount()
        {
            $bedCount = 1;
            return $bedCount;
        }

        public function getExtras()
        {
            $extras=array('TV', 'air-conditioner');
            return $extras;
        }

        public function getRoomInfo()
        {
            $roomInformation = [
                $this->getRoomType(),
                $this->getRestroom(),
                $this->getHasBalcony(),
                $this->getBedCount(),
                $this->getExtras()];
            return $roomInformation;
        }

        function __toString()
        {
            return parent::__toString();
        }

    }
}