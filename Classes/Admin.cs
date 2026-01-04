using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
	public class Admin : User
	{
		
		public Admin(string username, string password)
			: base(username, password) // send username & password to User
		{
			Role = UserRole.Admin;
		}

		// Admin action
		public void ManageSystem()
		{
			// Admin can manage users, vehicles, and reports
		}

		public void ApproveDamageReport(DamageReport report)
		{
			if (report != null)
			{
				report.ApprovedByAdmin = true;
			}
		}

	}
}
