using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
	public class BillingManager
	{
		// Calculate rental cost 
		public decimal CalculateTotalAmount(Rental rental, RateConfiguration rate)
		{
			if (rental == null || rate == null)
				return 0;

			DateTime start = rental.Reservation.StartDate;
			DateTime end = rental.Reservation.EndDate;

			int days = (end - start).Days;
			if (days <= 0)
				days = 1;

			decimal total = days * rate.DailyRate;

			// Overdue handling 
			if (rental.Status == RentalStatus.Overdue)
			{
				int overdueDays = (DateTime.Now - end).Days;
				if (overdueDays > 0)
				{
					total += overdueDays * rate.DailyRate;
				}
			}

			return total;
		}

		// Generate invoice
		public Invoice GenerateInvoice(Rental rental, RateConfiguration rate)
		{
			if (rental == null || rate == null)
				return null;

			Invoice invoice = new Invoice
			{
				Rental = rental,
				IssueDate = DateTime.Now,
				TotalAmount = CalculateTotalAmount(rental, rate),
				IsPaid = false
			};

			return invoice;
		}

		//  Add payment to invoice
		public void AddPayment(Invoice invoice, Payment payment)
		{
			if (invoice == null || payment == null)
				return;

			payment.Invoice = invoice;
			payment.PaymentDate = DateTime.Now;

			invoice.Payments.Add(payment);

			decimal paidAmount = 0;
			foreach (Payment p in invoice.Payments)
			{
				paidAmount += p.Amount;
			}

			if (paidAmount >= invoice.TotalAmount)
			{
				invoice.IsPaid = true;
			}
		}
	}
}
