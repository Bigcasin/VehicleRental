using System;
using System.Collections.Generic;

namespace VehicleRENTAL.Classes {

    public class Customer
    {
        public int customerId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public DateTime birthDate { get; set; }
        public int PhoneNum { get; set; }
        public string Nationality { get; set; }
        private bool BlackList { get; set; }
        private string loyaltypoints { get; set; }
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

