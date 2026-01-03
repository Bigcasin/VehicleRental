using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace VehicleRENTAL.Classes
{
    class Database
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(
                ConfigurationManager.ConnectionStrings["RentalDB"].ConnectionString
            );
        }
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
