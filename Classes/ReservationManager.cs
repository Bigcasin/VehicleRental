using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleRENTAL.Classes
{
	public class ReservationManager
	{
		private readonly List<Reservation> _reservations = new List<Reservation>();
		private readonly object _lock = new object();

		public bool IsVehicleAvailable(Vehicle vehicle, DateTime start, DateTime end)
		{
			// Validate inputs
			if (vehicle == null)
				return false;
			if (start >= end)
				return false;
			if (vehicle.Status != VehicleStatus.Available)
				return false;

			lock (_lock)
			{
				return !_reservations.Any(r =>
					r != null &&
					r.Vehicle != null &&
					r.Vehicle.VehicleId == vehicle.VehicleId &&
					(r.Status == ReservationStatus.Pending ||
					 r.Status == ReservationStatus.Confirmed ||
					 r.Status == ReservationStatus.PickedUp) &&
					start < r.EndDate &&
					end > r.StartDate
				);
			}
		}

		public Reservation CreateReservation(Customer customer, Vehicle vehicle, DateTime startDate, DateTime endDate)
		{
			if (customer == null || vehicle == null)
				return null;

			if (startDate >= endDate)
				return null;

			if (!IsVehicleAvailable(vehicle, startDate, endDate))
				return null;

			var reservation = new Reservation
			{
				Id = GetNextId(),
				Customer = customer,
				Vehicle = vehicle,
				StartDate = startDate,
				EndDate = endDate,
				Status = ReservationStatus.Pending
			};

			lock (_lock)
			{
				_reservations.Add(reservation);
			}

			return reservation;
		}

		public void ConfirmReservation(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.Confirmed;
			if (reservation.Vehicle != null)
				reservation.Vehicle.ChangeStatus(VehicleStatus.Reserved);
		}

		public void PickUpVehicle(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.PickedUp;
			if (reservation.Vehicle != null)
				reservation.Vehicle.ChangeStatus(VehicleStatus.Rented);
		}

		public void ReturnVehicle(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.Returned;
			if (reservation.Vehicle != null)
				reservation.Vehicle.ChangeStatus(VehicleStatus.Available);
		}

		public void CancelReservation(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.Cancelled;
			if (reservation.Vehicle != null)
				reservation.Vehicle.ChangeStatus(VehicleStatus.Available);
		}

		public List<Reservation> GetAllReservations()
		{
			lock (_lock)
			{
				// return a copy to avoid external modification
				return _reservations.ToList();
			}
		}

		private int GetNextId()
		{
			lock (_lock)
			{
				return _reservations.Count == 0 ? 1 : _reservations.Max(r => r.Id) + 1;
			}
		}
	}
}




