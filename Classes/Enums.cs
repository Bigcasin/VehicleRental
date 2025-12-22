using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
	public enum Status
	{
		Available,
		Rented,
		UnderMaintenance,
		OutOfService
	}

	public enum AdminLevel
	{
		Low,
		Medium,
		High
	}

	public enum DamageSeverity
	{
		Critical,
		Moderate,
		Light
	}

	public enum PaymentMethod
	{
		Cash,
		Card,
		Online,
		BankTransfer
	}


	public enum RentalStatus
	{
		Pending,
		Active,
		Completed,
		Cancelled,
		Overdue
	}

	public enum Report
	{
		Fleet,
		Rental
	}

	public enum ReservationStatus
	{
		Pending,
		Confirmed,
		PickedUp,
		Returned,
		Cancelled
	}

	public enum UserRole
	{
		Admin,
		RentalAgent
	}

	public enum VehicleCategory
	{
		Hatchback,
		Sedan,
		SUV,
		Pickup,
		Van
	}

	public enum FuelType
	{
		Gasoline,
		Diesel,
		Electric,
		Hybrid
	}

	public enum TransmissionType
	{
		Manual,
		Automatic
	}

	public enum VehicleStatus
	{
		Available,
		Reserved,
		Rented,
		UnderMaintenance,
		OutOfService,
		Retired
	}


}
