using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL
{
    public enum Types 
    {
        SUV,
        Sedan,
        Hatchack,
        Pickups
    }
    public class Cars
    {
        public List<Types> CarTypes()
        {
            return new List<Types>
        {
            Types.SUV,
            Types.Sedan,
            Types.Hatchack,
            Types.Pickups
        };
        }
    }
}
