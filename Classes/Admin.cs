using System.Collections.Generic;

namespace VehicleRENTAL.Classes
{
   
    public class Admin : User
    {
        public int adminId;
        private AdminLevel adminlvl;
        private List<string> permissions;

        public void ManageUsers()
        {

		// Admin action
		public void ManageSystem()
		{
			// Admin can manage users, vehicles, and reports
		}

        public void GenerateReports() 
        {

        }
        public void ConfigureUi() 
        {

        }
        public void DamageClaims() 
        { 

	}
}
