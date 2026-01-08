using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRENTAL.Classes
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public User Login(string username, string password)
        {
            return users.FirstOrDefault(u => u.Login(username, password));
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
