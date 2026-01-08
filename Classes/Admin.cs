using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ManageUsers()
        {
            CustomerManager cm = new CustomerManager();
            cm.LoadCustomers();   // or whatever method you already have
        }

        public void GenerateReports() 
        {
            ReportManager rm = new ReportManager();
            ReportModel report = rm.GenerateAllReports();

            rm.PrintReport(report);
        }
        public void ConfigureUi() 
        {

        }
        public void DamageClaims() 
        { 

        }
    }
}
