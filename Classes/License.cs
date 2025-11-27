using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class License
    {
        public int LicenseId;
        public string status;
        public DateTime ExpirationDate;
        public byte[] picture;
        public bool Expired() 
        { 
            return ExpirationDate <= DateTime.Now;
        }
        public bool Valid() 
        {
            return ExpirationDate > DateTime.Now;
        } 
    }
}
