namespace VehicleRENTAL.Classes {
    public enum Status {
        Available,
        Rented,
        UnderMaintenance,
        OutOfService
    }

    public enum AdminLevel {
        Low,
        Medium,
        High
    }

    public enum DamageSeverity {
        Critical,
        Moderate,
        Light
    }

    public enum PaymentMethod {
        Cash,
        Card,
        Online,
        BankTransfer
    }


    public enum RentalStatus {
        Pending,
        Active,
        Completed,
        Cancelled,
        Overdue
    }

    public enum Report {
        Fleet,
        Rental
    }

	public enum ReservationStatus
	{
		Pending,
		Confirmed,
		PickedUp,  //ang vehicles kay unavailable kung pending,confirmed, or pickedup

		Returned,
		Cancelled //ignored if returned or cancelled
	}

    public enum UserRole {
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
		Unavailable,
		Reserved,
		Rented,
		UnderMaintenance,
		OutOfService,
		Retired
	}

	public enum PaymentStatus
	{
		Unpaid,
		Paid
	}




}
