using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class CustomerManager
    {
		private List<Customer> customers = new List<Customer>();

		public void RegisterCustomer(Customer customer) 
        {
			if (!ValidateCustomerData(customer))
				return;

			customers.Add(customer);
		}
		public void UpdateCustomer(Customer customer)
		{
			var existingCustomer = customers.FirstOrDefault(c => c.Id == customer.Id);

			if (existingCustomer == null)
				return;

			existingCustomer.Firstname = customer.Firstname;
			existingCustomer.Lastname = customer.Lastname;
			existingCustomer.Phone = customer.Phone;
			existingCustomer.License = customer.License;
			existingCustomer.IsBlacklisted = customer.IsBlacklisted;
		}

		public bool VerifyLicense(License license) 
        { 
            return true;
        }
        public bool ValidateCustomerData(Customer customer) {
        return true;
        }
    }
}
