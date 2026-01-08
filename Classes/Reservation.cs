using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
	public class Reservation
	{
		public int Id { get; set; }

		public Customer Customer { get; set; }
		public Vehicle Vehicle { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public ReservationStatus Status { get; set; }

		// Used later for billing & reports
		public int RentalDays
		{
			get
			{
				return (EndDate - StartDate).Days;
			}
		}
	}
}

