using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class Invoice
    {
        public int InvoiceID { get; set; }

        public Rental Rental { get; set; }

        public DateTime IssueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }

        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
