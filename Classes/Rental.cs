using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum RentalStatus
    {
        Pending,        
        Active,         
        Completed,      
        Cancelled,      
        Overdue         
    }
    public class Rental
    {
        public int RentalId { get; set; }
        public Reservation Reservation { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public double FinalMileage { get; set; }
        public RentalStatus Status { get; set; }
    }
}
