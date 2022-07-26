using BankManagementSystem.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer
{
    class LogInDataAccess:DataAccess
    {
        public int UserLoginValidation(User user)
        {
            string sql = "SELECT * FROM Users WHERE Email='" + user.Email + "'AND Password='" + user.Password + "'AND UserType='" + user.UserType + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return 1;
            }
            return -1;
        }
    }
}
