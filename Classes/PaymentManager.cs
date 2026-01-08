using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class PaymentManager
    {
        private List<Payment> payments = new List<Payment>();

        public void ProcessPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public List<Payment> GetAllPayments()
        {
            return payments;
        }
    }
}
