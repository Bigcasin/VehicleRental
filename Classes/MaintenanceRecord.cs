using System;

namespace VehicleRENTAL.Classes {
    public class MaintenanceRecord {
        public int RecordID { get; set; }
        public Vehicle Vehicle { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }
        public string PerformedBy { get; set; }
    }
}
