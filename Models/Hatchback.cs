using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Models
{
    public class Hatchback : Vehicle 
    {
        public int CargoCapacity { get; set; }
        public bool FunctionsFileAndDoor { get; set; }

        public override decimal CalculateRate(decimal auto)
        {
            return auto + CargoCapacity;
        }
    }
}
