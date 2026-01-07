using System;
using System.Collections.Generic;

namespace VehicleRENTAL.Classes {


    public abstract class Vehicle {
        public int vehicleId { get; set; }
        public string model { get; set; }
        public string Color { get; set; }
        public DateTime year { get; set; }
        public string licensePlate { get; set; }
        public string fuelType { get; set; }
        public Status vehiclestatus { get; set; }
        public List<byte[]> Photo { get; set; }
        public decimal fuelCapacity { get; set; }

        public abstract decimal CalculateRate();

        public string CarStatus() {
        return vehiclestatus.ToString();
        }

        public bool Availability() {
        return vehiclestatus == Status.Available;
        }
    }
}
