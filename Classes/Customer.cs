using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
	public class Customer
	{
		public int Id { get; set; }

		public string Firstname { get; set; }
		public string Lastname { get; set; }

		public string Name => $"{Firstname} {Lastname}";

		public int Age { get; set; }
		public string Gender { get; set; }
		public DateTime BirthDate { get; set; }

		public string Phone { get; set; }
		public string Nationality { get; set; }

		public bool IsBlacklisted { get; set; }

		public string Loyaltypoints { get; set; }

		public License License { get; set; }

		public List<Rental> RentalHistory { get; set; } = new List<Rental>();

		public bool AvailabilityForRental()
		{
			return !IsBlacklisted;
		}
	}
}

