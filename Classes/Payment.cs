using System;

namespace VehicleRENTAL.Classes {

    public class Payment {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }
        public Invoice Invoice { get; set; }

    }
}
