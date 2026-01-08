using System.Collections.Generic;

namespace VehicleRENTAL.Classes {
    
    public class Admin : User {
        public int adminId;
        private AdminLevel adminlvl;
        private List<string> permissions;

        // Add a constructor that calls the base User constructor with username and password
        public Admin(string username, string password) : base(username, password)
        {
            // Initialize other fields if needed
            permissions = new List<string>();
        }

        public void ManageUsers() {
        }

        // Admin action
        public void ManageSystem() {
        // Admin can manage users, vehicles, and reports
        }

        public void GenerateReports() {

        }
        public void ConfigureUi() {

        }
        public void DamageClaims() {

        }
    }
}