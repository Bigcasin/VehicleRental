using System.Collections.Generic;


namespace VehicleRENTAL.Classes
{

    public class Admin : User
    {
        public int AdminId { get; set; }
        public AdminLevel AdminLevel { get; set; }
        public List<string> Permissions { get; private set; }
        public Admin(string username, string password) : base(username, password)
        {
            Role = UserRole.Admin;

            Permissions = new List<string> 
            {
            "UserManagement",
            "FleetManagement",
            "RateManagement",
            "Reports",
            "DamageApproval"
            };
        }

        public void GenerateReports()
        {
            ReportManager rm = new ReportManager();
            ReportModel report = rm.GenerateAllReports();
            rm.PrintReport(report);
        }

        public void ManageUsers()
        {
            UserManager um = new UserManager();
        }

        // Admin action
        public void ManageSystem()
        {
            ManageUsers();
            ManageFleet();
            GenerateReports();
            DamageClaims();
        }

        public void ConfigureUi()
        {

        }

        public void DamageClaims()
        {
            DamageReportManager drm = new DamageReportManager();
            var pending = drm.LoadPendingReports();
        }

        public void ManageFleet()
        {
            VehicleManager vm = new VehicleManager();
            VehicleManager.Instance.LoadVehicles();
        }

        public bool HasPermission(string permission)
        {
            return Permissions.Contains(permission);
        }
        public void ManageRates()
        {
            RateManager rm = new RateManager();
        }

        public void ApproveDamageClaims()
        {
            DamageReportManager dm = new DamageReportManager();
        }
    }
}