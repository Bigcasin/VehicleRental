using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Models
{
    internal class Sedan : Vehicle
    {
        public decimal TrunkCapacity { get; set; }
        public bool Sunroof {  get; set; }

        public override decimal CalculateRate(decimal auto)
        {
            return auto + TrunkCapacity;
        }
    }
}
