using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleRENTAL.Classes;

namespace VehicleRENTAL.Tests
{
	[TestClass]
	public class ReservationManagerTests
	{
		[TestMethod]
		public void IsVehicleAvailable_NoReservations_ReturnsTrue()
		{
			var mgr = new ReservationManager();
			var vehicle = new Vehicle { VehicleId = 1, Status = VehicleStatus.Available };
			var start = DateTime.Today.AddDays(1);
			var end = start.AddDays(2);

			Assert.IsTrue(mgr.IsVehicleAvailable(vehicle, start, end));
		}

		[TestMethod]
		public void CreateReservation_BasicFlow_MakesReservationAndBlocksDates()
		{
			var mgr = new ReservationManager();
			var vehicle = new Vehicle { VehicleId = 10, Status = VehicleStatus.Available };
			var customer = new Customer { customerId = 1, firstname = "A", lastname = "B", PhoneNum = 12345 };
			var start = DateTime.Today.AddDays(1);
			var end = start.AddDays(3);

			var res = mgr.CreateReservation(customer, vehicle, start, end);

			Assert.IsNotNull(res);
			Assert.AreEqual(1, res.Id);
			Assert.IsFalse(mgr.IsVehicleAvailable(vehicle, start.AddDays(1), end.AddDays(-1)));
		}

		[TestMethod]
		public void IsVehicleAvailable_NullVehicle_ReturnsFalse()
		{
			var mgr = new ReservationManager();
			Assert.IsFalse(mgr.IsVehicleAvailable(null, DateTime.Today, DateTime.Today.AddDays(1)));
		}

		[TestMethod]
		public void CreateReservation_InvalidDates_ReturnsNull()
		{
			var mgr = new ReservationManager();
			var vehicle = new Vehicle { VehicleId = 2, Status = VehicleStatus.Available };
			var customer = new Customer { customerId = 2, firstname = "X", lastname = "Y", PhoneNum = 999 };

			var res = mgr.CreateReservation(customer, vehicle, DateTime.Today.AddDays(2), DateTime.Today.AddDays(1));
			Assert.IsNull(res);
		}
	}
}