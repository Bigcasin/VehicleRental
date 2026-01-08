using System;

namespace VehicleRENTAL.Classes {

    public class Rental {
        // DB fields
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Business objects
        public Reservation Reservation { get; set; }

        // Rental workflow
        public DateTime PickupTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public double FinalMileage { get; set; }
        public RentalStatus Status { get; set; }
    }
}
