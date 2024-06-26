﻿using CodeDrivers.Models.Car;

namespace CodeDriversMVC.Models
{
    public class UserReservationModel
    {
        public int ReservationId { get; set; }
        public CarBrand Brand { get; set; }
        public string Model { get; set; }
        public DateTime ReservationFrom { get; set; }
        public DateTime ReservationTo { get; set; }
        public decimal TotalReservationPrice { get; set; }
        public int ReservationDuration { get; set; }
    }
}
