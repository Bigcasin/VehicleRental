using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class Pickup : Vehicle
    {
        public decimal payloadCapacity;
        public decimal trunkCapacity;

        public override decimal CalculateRate()
        {
            return 20000;
        }
    }
}
