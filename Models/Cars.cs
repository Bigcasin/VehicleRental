using System.Collections.Generic;

namespace VehicleRENTAL {
    public enum Types {
        SUV,
        Sedan,
        Hatchack,
        Pickups
    }
    public class Cars {
        public List<Types> CarTypes() {
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
