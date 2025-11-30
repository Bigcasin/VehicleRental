using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class SUV : Vehicle
    {
        public decimal towingCapability;
        public decimal groundClearance;

        public override decimal CalculateRate()
        {
            return 30000;
        }
    }
}
