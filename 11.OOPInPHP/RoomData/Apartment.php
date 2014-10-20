<?php

namespace RoomData;

class Apartment extends Room{

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, $price);
    }

    public function getRoomType()
    {
        $roomType = RoomType::Diamond;
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
        $bedCount = 4;
        return $bedCount;
    }

    public function getExtras()
    {
        $extras=array('TV', 'Air-conditioner', 'Refrigerator', 'kitchen box', 'mini-bar', 'bathtub', 'free Wi-fi');
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