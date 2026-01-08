using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class VehicleInspection
    {
        public int InspectionId { get; set; }
        public Rental Rental { get; set; }
        public double OdometerReading { get; set; }
        public double FuelLevel { get; set; }
        public string InteriorCondition { get; set; }
        public string ExteriorCondition { get; set; }
    }
}
