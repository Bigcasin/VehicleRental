using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum DateRange
    {
        Daily,
        Weekly,
        Monthly,
        Yearly,
        Custom
    }
    public class ReservationManager
    {
        public Reservation CreateReservation(Customer customer, Vehicle vechicle, DateRange date)
        {
            return new Reservation();
        }
        public void CancelReservation() 
        {
            
        }
        public bool CheckAvailability(int reservationid) 
        {
            return false;
        }
        public string GenerateReservationNumber() 
        {
            return new Random().Next(100000, 999999).ToString();
        }
    } 
}
