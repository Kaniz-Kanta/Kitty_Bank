using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using BankManagementSystem.Data_Access_Layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }
        public List<User> GetUsersByEmail(string email)
        {
            //UserDataAccess usersDataAccess = new UserDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.userDataAccess.GetUserByEmail(email);
        }
        public List<User> GetUsersByUserId(int userId)
        {
            //UserDataAccess usersDataAccess = new UserDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.userDataAccess.GetUserByUserId(userId);
        }
        public List<User> GetAllUsers() 
        {
            return this.userDataAccess.GetUsers();
        }

        public int AddUser(string userName, string password, string email, string phoneNumber,string userType, string registrationDate)
        {
            User user = new User()
            {
                UserName = userName,
                Password = password,
                Email = email,
                PhoneNumber = phoneNumber,
                UserType= userType,
                RegistrationDate = registrationDate
            };
            return this.userDataAccess.AddUser(user);
        }
        public int UpdateUser(int userId, string userName, string password, string email, string phoneNumber, string userType, string updateDate)
        {
            User user = new User()
            {
                UserId = userId,
                UserName = userName,
                Password = password,
                Email = email,
                PhoneNumber = phoneNumber,
                UserType = userType,
                RegistrationDate = updateDate
            };
            return this.userDataAccess.UpdateUser(user);
        }
        public int DeleteUser(int userId)
        {
            return this.userDataAccess.DeleteUser(userId);
        }
        
    }
}
