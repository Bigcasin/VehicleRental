using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public enum AdminLevel
    {
        Low,
        Medium,
        High
    }
    public class Admin : Users
    {
        public int adminId;
        private AdminLevel adminlvl;
        private List<string> permissions;

        public void ManageUsers()
        {

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
}
