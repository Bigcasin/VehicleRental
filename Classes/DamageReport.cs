using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class DamageReport
    {
        public int ReportId { get; set; }
        public Rental Rental { get; set; }
        public List<Damage> Damages { get; set; }
        public decimal EstimatedCost { get; set; }
        public bool ApprovedByAdmin { get; set; }
    }
}
