using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Models
{


    public abstract class Vehicle
{
    public int VehicleId { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public string LicensePlate { get; set; }
    public string ListType { get; set; }
    public string VehicleStatus { get; set; }
    public List<String> Photos { get; set; }
    public decimal FuelCapacity { get; set; }

    public abstract decimal CalculateRate(decimal auto);
    public string CarStatus() => $"Vehicle {VehicleId}: {Model}";
    public bool Availability() => VehicleStatus == "Avalibale";

    }

}
