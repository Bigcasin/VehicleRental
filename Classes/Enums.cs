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

	public enum UserType
	{
		Admin,
		Customer,
		Agent
	}

	public enum InvoiceStatus
	{
		Pending,
		Approved,
		Rejected,
		Paid
	}

	public enum NotificationType
	{
		ReservationConfirmation,
		ReservationCancellation,
		InvoiceGeneration
	}

	public enum ReportType
	{
		FleetUsage,
		Revenue,
		CustomerFeedback
	}

	public enum FeedbackRating
	{
		OneStar,
		TwoStars,
		ThreeStars,
		FourStars,
		FiveStars
	}

	public enum PaymentGateway
	{
		PayPal,
		Stripe,
		Square,
		BankTransfer
	}

	public enum Currency
	{
		USD,
		EUR,
		GBP,
		PHP
	}

	public enum DiscountType
	{
		Percentage,
		FlatRate
	}

	public enum TaxType
	{
		None,
		SalesTax,
		VAT
	}

	public enum UserStatus
	{
		Active,
		Inactive,
		Suspended
	}

	public enum VehicleImageType
	{
		Exterior,
		Interior,
		LicensePlate
	}

	public enum DocumentType
	{
		DrivingLicense,
		Passport,
		IDCard
	}

	public enum NotificationStatus
	{
		Unread,
		Read,
		Archived
	}

	public enum SessionStatus
	{
		Active,
		Expired,
		Terminated
	}

	public enum TransactionStatus
	{
		Successful,
		Failed,
		Pending,
		 refunded
	}
}
