using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class MaintenanceManager
    {
        public void ScheduleMaintenance(Vehicle vehicle, string description) 
        {
            if (vehicle == null) 
            { 
                throw new ArgumentNullException(nameof(vehicle));
            }
        }
        public void RecordMaintenance(MaintenanceRecord record) 
        {
            
        }
        public void MarkVehicleUnvailable(Vehicle vehicle) 
        {
            
        }
        public void MarkVehicleAvailable(Vehicle vehicle) 
        {
            
        }
        public decimal EstimateCost(string Description) 
        {
            return 0;
        }
    }
}
