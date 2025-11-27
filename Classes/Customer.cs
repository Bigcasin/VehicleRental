using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class Rental
    {
        
    }
    public class Customer
    {
        public int customerId;
        public string firstname;
        public string lastname;
        public int age;
        public string gender;
        public DateTime birthDate;
        public int PhoneNum;
        public string Nationality;
        private bool BlackList;
        private string loyaltypoints;
        public List<Rental> RentalHistory() 
        { 
            return new List<Rental>();
        }
        public bool AvailabilityForRental() 
        { 
            return !BlackList;
        }
    }
}
