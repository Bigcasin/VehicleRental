namespace VehicleRENTAL.Classes {

    public class RateConfiguration {
        public int RateId { get; set; }
        public Category VehicleCategory { get; set; }
        public decimal DailyRate { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal MonthlyRate { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
