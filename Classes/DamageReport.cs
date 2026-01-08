using System.Collections.Generic;

namespace VehicleRENTAL.Classes
{
	public class DamageReport
	{
        public int ReportId { get; set; }

        public int RentalId { get; set; }

        public Rental Rental { get; set; }

        public DateTime ReportDate { get; set; }

        public List<Damage> Damages { get; set; } = new List<Damage>();

        public decimal EstimatedCost { get; set; }

        public bool ApprovedByAdmin { get; set; }
    }
}
