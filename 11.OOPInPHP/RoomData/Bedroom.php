<?php

namespace RoomData;

class Bedroom extends  Room{

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, $price);
    }

    public function getRoomType()
    {
        $roomType = RoomType::Gold;
        return $roomType;
    }

    public function getRestroom()
    {
        $restroom = "Yes";
        return $restroom;
    }

    public function getHasBalcony()
    {
        $hasBalcony = "Yes";
        return $hasBalcony;
    }

    public function getBedCount()
    {
        $bedCount = 2;
        return $bedCount;
    }

    public function getExtras()
    {
        $extras=array('TV', 'Air-conditioner', 'Refrigerator', 'mini-bar', 'bathtub');
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