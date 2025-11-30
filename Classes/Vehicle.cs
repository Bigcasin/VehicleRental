using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum Status
    {
        Available,
        Rented,
        UnderMaintenance,
        OutOfService
    }
    public abstract class Vehicle
    {
        public int vehicleId;
        public string model;
        public string Color;
        public DateTime year;
        public string licensePlate;
        public string fuelType;
        public Status vehiclestatus;
        public List<byte[]> Photo;
        public decimal fuelCapacity;

        public abstract decimal CalculateRate();

        public string CarStatus() 
        {
            return vehiclestatus.ToString();
        }

        public bool Availability() 
        {
            return vehiclestatus == Status.Available;
        }
    }
}
