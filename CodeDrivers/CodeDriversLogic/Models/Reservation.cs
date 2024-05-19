using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDrivers.Models.Car
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime ReservationFrom { get; set; }
        public DateTime ReservationTo { get; set; }
        public int Duration { get; set; }
        public decimal TotalReservationPrice { get; set; }
        public Car Car { get; set; }
        public User Owner { get; set; }

    }
}
