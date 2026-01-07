using System;

namespace VehicleRENTAL.Classes
{
	public class MaintenanceManager
	{
		// Store maintenance records (in-memory for now)
		private List<MaintenanceRecord> records = new List<MaintenanceRecord>();

		// Schedule maintenance for a vehicle
		public MaintenanceRecord ScheduleMaintenance(Vehicle vehicle, string description)
		{
			if (vehicle == null)
			{
				throw new ArgumentNullException(nameof(vehicle));
			}

			MaintenanceRecord record = new MaintenanceRecord
			{
				Vehicle = vehicle,
				Description = description,
				Date = DateTime.Now,
				Cost = EstimateCost(description),
				PerformedBy = "Not Assigned"
			};

			// Mark vehicle unavailable while under maintenance
			MarkVehicleUnavailable(vehicle);

			records.Add(record);
			return record;
		}

		// Record completed maintenance
		public void RecordMaintenance(MaintenanceRecord record)
		{
			if (record == null)
			{
				throw new ArgumentNullException(nameof(record));
			}

			// When maintenance is done, make vehicle available again
			MarkVehicleAvailable(record.Vehicle);
		}

		// Mark vehicle unavailable
		public void MarkVehicleUnavailable(Vehicle vehicle)
		{
			if (vehicle != null)
			{
				vehicle.ChangeStatus(VehicleStatus.Unavailable);
			}
		}

		// Mark vehicle available
		public void MarkVehicleAvailable(Vehicle vehicle)
		{
			if (vehicle != null)
			{
				vehicle.ChangeStatus(VehicleStatus.Available);
			}
		}

		// Estimate maintenance cost 
		public decimal EstimateCost(string description)
		{
			if (string.IsNullOrEmpty(description))
				return 0;

			if (description.ToLower().Contains("engine"))
				return 5000;

			if (description.ToLower().Contains("oil"))
				return 1500;

			if (description.ToLower().Contains("tire"))
				return 2000;

			return 1000; 
		}
	}
}

