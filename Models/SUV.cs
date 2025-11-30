using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Models
{
    public class SUV : Vehicle
    {
        public bool FourWheeler { get; set; }
        public decimal TowingCapability { get; set; }
        public decimal GroundClearance { get; set; }

        public override decimal CalculateRate(decimal auto)
        {
            return auto + TowingCapability + GroundClearance;

        }

    }
}




    


    

