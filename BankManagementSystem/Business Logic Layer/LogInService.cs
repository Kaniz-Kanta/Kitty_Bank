using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using BankManagementSystem.Data_Access_Layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Business_Logic_Layer
{
    class LogInService
    {
        LogInDataAccess logInDataAccess;
        public LogInService()
        {
            this.logInDataAccess = new LogInDataAccess();
        }
        public int LoginValidation(string email, string password, string userType)
        {
            User user = new User()
            {
                Email = email,
                Password = password,
                UserType= userType
            };
            return logInDataAccess.UserLoginValidation(user);
        }
    }
}
