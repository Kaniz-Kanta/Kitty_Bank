using BankManagementSystem.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {

        public List<User> GetUsers()
         {
             string sql = "SELECT * FROM Users";
             SqlDataReader reader = this.GetData(sql);
             List<User> users = new List<User>();
             while (reader.Read())
             {
                 User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.PhoneNumber = reader["PhoneNumber"].ToString();
                user.UserType = reader["UserType"].ToString();
                user.RegistrationDate = reader["RegistrationDate"].ToString();
                users.Add(user);
             }
             return users;
         }
        
        public List<User> GetUserByEmail(string email)
        {
            string sql = "SELECT * FROM Users WHERE Email='" + email + "'";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.PhoneNumber = reader["PhoneNumber"].ToString();
                user.UserType = reader["UserType"].ToString();
                user.RegistrationDate = reader["RegistrationDate"].ToString();
                users.Add(user);
            }
            return users;
        }
        public List<User> GetUserByUserId(int userId)
        {
            string sql = "SELECT * FROM Users WHERE UserId='" + userId + "'";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.PhoneNumber = reader["PhoneNumber"].ToString();
                user.UserType = reader["UserType"].ToString();
                user.RegistrationDate = reader["RegistrationDate"].ToString();
                users.Add(user);
            }
            return users;
        }
        public int AddUser(User user)
        {
            string sql = "INSERT INTO Users(UserName,Password, Email, PhoneNumber, UserType, RegistrationDate) VALUES('" + user.UserName + "','" + user.Password + "','" + user.Email + "','" + user.PhoneNumber + "','" + user.UserType + "','" + user.RegistrationDate + "')";
            return this.ExecuteQuery(sql);
        }

        public int UpdateUser(User user)
        {
            string sql = "UPDATE Users SET UserName='" + user.UserName + "', Password='" + user.Password + "', Email='" + user.Email + "',PhoneNumber='" + user.PhoneNumber + "',UserType='" + user.UserType + "',RegistrationDate='" + user.RegistrationDate + "' WHERE UserID='" + user.UserId + "'";
            return this.ExecuteQuery(sql);
        }
        public int DeleteUser(int userId)
        {
            string sql = "DELETE FROM Users WHERE UserId='" + userId + "'";
            return this.ExecuteQuery(sql);
        }

    }
}
