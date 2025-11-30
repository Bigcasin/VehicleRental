using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Models
{
    public abstract class Pickup : Vehicle
    {
        public decimal PayloadCapacity { get; set; }
        public decimal TrunkCapacity { get; set; }

        public abstract override decimal CalculateRate(decimal auto);
    }
}
