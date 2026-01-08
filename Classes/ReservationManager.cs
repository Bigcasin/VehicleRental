using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleRENTAL.Classes
{
	public class ReservationManager
	{
		private List<Reservation> reservations = new List<Reservation>();

		public bool IsVehicleAvailable(Vehicle vehicle, DateTime start, DateTime end)
		{
			if (vehicle.Status != VehicleStatus.Available)
				return false;

			return !reservations.Any(r =>
				r.Vehicle.VehicleId == vehicle.VehicleId &&
				(r.Status == ReservationStatus.Pending ||
				 r.Status == ReservationStatus.Confirmed ||
				 r.Status == ReservationStatus.PickedUp) &&
				start < r.EndDate &&
				end > r.StartDate
			);
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
				Id = reservations.Count + 1,
				Customer = customer,
				Vehicle = vehicle,
				StartDate = startDate,
				EndDate = endDate,
				Status = ReservationStatus.Pending
			};

			reservations.Add(reservation);
			return reservation;
		}

		public void ConfirmReservation(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.Confirmed;
			reservation.Vehicle.ChangeStatus(VehicleStatus.Reserved);
		}

		public void PickUpVehicle(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.PickedUp;
			reservation.Vehicle.ChangeStatus(VehicleStatus.Rented);
		}

		public void ReturnVehicle(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.Returned;
			reservation.Vehicle.ChangeStatus(VehicleStatus.Available);
		}

		public void CancelReservation(Reservation reservation)
		{
			if (reservation == null)
				return;

			reservation.Status = ReservationStatus.Cancelled;
			reservation.Vehicle.ChangeStatus(VehicleStatus.Available);
		}

		public List<Reservation> GetAllReservations()
		{
			return reservations;
		}
	}
}




