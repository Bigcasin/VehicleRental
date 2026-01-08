using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class RateManager
    {
        private List<RateConfiguration> rates = new List<RateConfiguration>();

        public void AddRate(RateConfiguration rate)
        {
            rates.Add(rate);
        }

        public List<RateConfiguration> GetRates()
        {
            return rates;
        }

        public RateConfiguration GetRateByVehicle(VehicleCategory category)
        {
            return rates.FirstOrDefault(r => r.Category == category);
        }
    }
}
