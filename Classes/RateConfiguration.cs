using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum Category
    {
        Hatchback,
        Sedan,
        SUV,
        Pickup,
    }
    public class RateConfiguration
    {
        public int RateId { get; set; }
        public Category VehicleCategory { get; set; }
        public decimal DailyRate { get; set; }
        public decimal WeeklyRate { get; set; }
        public decimal MonthlyRate { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
