using System;

namespace VehicleRENTAL.Classes {

    public class Reservation {
        public int ReservationID { get; set; }
        public Customer Customer { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public ReservationStatus Status { get; set; }
        public decimal TotalEstimatedCost { get; set; }
    }
}
