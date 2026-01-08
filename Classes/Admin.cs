using System.Collections.Generic;


namespace VehicleRENTAL.Classes
{
   
    public class Admin : User
    {
        public int AdminId { get; set; }
        public AdminLevel AdminLevel { get; set; }
        public List<string> Permissions { get; set; } = new List<string>();
        public Admin()
        {
            Role = UserRole.Admin;

            Permissions.Add("UserManagement");
            Permissions.Add("FleetManagement");
            Permissions.Add("RateManagement");
            Permissions.Add("Reports");
            Permissions.Add("DamageApproval");
        }

namespace VehicleRENTAL.Classes {
    
    public class Admin : User {
        public int adminId;
        private AdminLevel adminlvl;
        private List<string> permissions;


        // Add a constructor that calls the base User constructor with username and password
        public Admin(string username, string password) : base(username, password)
        {

            CustomerManager cm = new CustomerManager();
            cm.LoadCustomers();   // or whatever method you already have
        }

        public void GenerateReports() 
        {
            ReportManager rm = new ReportManager();
            ReportModel report = rm.GenerateAllReports();

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


            rm.PrintReport(report);
        }
        public void ConfigureUi() {

        }
        public void DamageClaims() {

        }
    }
}