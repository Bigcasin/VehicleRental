using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VehicleRENTAL.Classes
{
    public enum UserRole
    {
        Admin,
        RentalAgent
    }
    public abstract class Users
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int PhoneNum { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public UserRole Role { get; set; }
        public string Nationality { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }
        public void Logout() 
        { 

        }
        public string UpdateProfile() 
        { 
            return Username;
        }
    }
}


