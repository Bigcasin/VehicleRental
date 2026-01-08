using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{

	
	public class RentalAgent
	{
		// Start rental (Pickup vehicle)
		public Rental StartRental(Reservation reservation)
		{
			if (reservation == null)
				return null;

			// Only confirmed reservations can be picked up
			if (reservation.Status != ReservationStatus.Confirmed)
				return null;

			// Update reservation
			reservation.Status = ReservationStatus.PickedUp;

			// Create rental
			Rental rental = new Rental
			{
				Reservation = reservation,
				PickupTime = DateTime.Now,
				Status = RentalStatus.Active
			};

			// Update vehicle state
			reservation.Vehicle.ChangeStatus(VehicleStatus.Rented);

			return rental;
		}

		// Return vehicle (End rental)
		public void ReturnRental(Rental rental, double finalMileage)
		{
			if (rental == null)
				return;

			rental.ReturnTime = DateTime.Now;
			rental.FinalMileage = finalMileage;
			rental.Status = RentalStatus.Completed;

			// Update reservation
			rental.Reservation.Status = ReservationStatus.Returned;

			// Make vehicle available again
			rental.Reservation.Vehicle.ChangeStatus(VehicleStatus.Available);
		}

		// Cancel rental (before pickup)
		public void CancelRental(Rental rental)
		{
			if (rental == null)
				return;

			rental.Status = RentalStatus.Cancelled;
			rental.Reservation.Status = ReservationStatus.Cancelled;

			rental.Reservation.Vehicle.ChangeStatus(VehicleStatus.Available);
		}

		// Check overdue rental
		public void CheckOverdue(Rental rental)
		{
			if (rental == null)
				return;

			if (rental.Status == RentalStatus.Active &&
				DateTime.Now > rental.Reservation.EndDate)
			{
				rental.Status = RentalStatus.Overdue;
			}
		} 
		
		
	}       
}
