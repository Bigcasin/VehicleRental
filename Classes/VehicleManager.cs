using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
	public class VehicleManager
	{
		private static VehicleManager _instance;

		public static VehicleManager Instance
		{
			get
			{
				if (_instance == null)
					_instance = new VehicleManager();
				return _instance;
			}
		}

		public List<Vehicle> Vehicles { get; } = new List<Vehicle>();

		public void AddVehicle(Vehicle vehicle)
		{
			Vehicles.Add(vehicle);
		}
	}


}
