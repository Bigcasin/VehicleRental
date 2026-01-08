namespace VehicleRENTAL.Classes {

    public class RateConfiguration {
        public int RateId { get; set; }

        public VehicleCategory Category { get; set; }
        public decimal DailyRate { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal MonthlyRate { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
