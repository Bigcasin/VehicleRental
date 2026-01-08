using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class CustomerManager
    {
        private readonly List<Customer> customers = new List<Customer>();

        public void RegisterCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            // Basic validation
            if (!ValidateCustomerData(customer))
                return;

            // Prevent adding duplicates by customerId
            if (customers.Any(c => c.customerId == customer.customerId))
                return;

            customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer == null)
                return;

            var existingCustomer = customers.FirstOrDefault(c => c.customerId == customer.customerId);

            if (existingCustomer == null)
                return;

            // Update only the public fields that exist on your Customer class
            existingCustomer.firstname = customer.firstname;
            existingCustomer.lastname = customer.lastname;
            existingCustomer.age = customer.age;
            existingCustomer.gender = customer.gender;
            existingCustomer.birthDate = customer.birthDate;
            existingCustomer.PhoneNum = customer.PhoneNum;
            existingCustomer.Nationality = customer.Nationality;
            // Do not attempt to set private members like BlackList or loyaltypoints here
        }

        public bool VerifyLicense(License license)
        {
            if (license == null)
                return false;

            // Use the License.Valid() method if implemented in your License class
            try
            {
                return license.Valid();
            }
            catch
            {
                // Fallback if Valid() throws or is not implemented properly
                return !license.Expired();
            }
        }

        public bool ValidateCustomerData(Customer customer)
        {
            if (customer == null)
                return false;

            if (string.IsNullOrWhiteSpace(customer.firstname))
                return false;

            if (string.IsNullOrWhiteSpace(customer.lastname))
                return false;

            if (customer.PhoneNum <= 0)
                return false;

            // Ensure the customer is allowed to rent (calls AvailabilityForRental which uses BlackList)
            try
            {
                if (!customer.AvailabilityForRental())
                    return false;
            }
            catch
            {
                // If AvailabilityForRental isn't functional, don't block registration here
            }

            return true;
        }

        // Helpers
        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.customerId == id);
        }

        public List<Customer> GetAllCustomers()
        {
            return customers.ToList();
        }
    }
}
