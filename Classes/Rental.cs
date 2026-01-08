using System;

namespace VehicleRENTAL.Classes {

    public class Rental {
        public int RentalId { get; set; }
        public Reservation Reservation { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public double FinalMileage { get; set; }
        public RentalStatus Status { get; set; }
    }
}
