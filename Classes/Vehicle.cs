using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{


	public class Vehicle
	{
		public int VehicleId { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }
		public string LicensePlate { get; set; }
		public string VIN { get; set; }

		public VehicleCategory Category { get; set; }
		public TransmissionType Transmission { get; set; }
		public FuelType FuelType { get; set; }

		public int SeatingCapacity { get; set; }
		public double Mileage { get; set; }

		public VehicleStatus Status { get; set; }

		public bool HasAirConditioning { get; set; }
		public bool HasGPS { get; set; }
		public bool HasBluetooth { get; set; }
		public bool HasChildSeat { get; set; }
		public bool HasInsuranceCoverage { get; set; }
		public double CargoCapacity { get; set; }
		public double FuelEfficiency { get; set; } 

		public void UpdateMileage(double newMileage)
		{
			Mileage = newMileage;
		}

		public void ChangeStatus(VehicleStatus newStatus)
		{
			Status = newStatus;
		}
	}

}
