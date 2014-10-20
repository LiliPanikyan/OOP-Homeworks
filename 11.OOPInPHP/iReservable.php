<?php
use ReservationData\Reservation;

interface iReservable {
    function addReservation(Reservation $reservation);
    function removeReservation(Reservation $reservation);
} 