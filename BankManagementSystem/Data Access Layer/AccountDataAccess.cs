using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankManagementSystem.Data_Access_Layer
{
    class AccountDataAccess:DataAccess
    {
        public List<Account> GetAccounts()
        {
            string sql = "SELECT * FROM Accounts";
            SqlDataReader reader = this.GetData(sql);
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.AccountNumber= Convert.ToInt32(reader["AccountNumber"]);
                account.AccountName = reader["AccountName"].ToString();
                account.AccountType = reader["AccountType"].ToString();
                account.Email = reader["Email"].ToString();
                account.PhoneNumber = reader["PhoneNumber"].ToString();
                account.Balance = Convert.ToSingle(reader["Balance"]);
                account.DateOfBirth = reader["DateOfBirth"].ToString();
                account.Address = reader["Address"].ToString();
                account.Occupation = reader["Occupation"].ToString();
                account.AccountOpeningDate = reader["AccountOpeningDate"].ToString();
                account.BranchName = reader["BranchName"].ToString();
                accounts.Add(account);
            }
            return accounts;
        }

        public List<Account> GetAccountByPhoneNumber(string phoneNumber)
        {
            string sql = "SELECT * FROM Accounts WHERE PhoneNumber='" + phoneNumber + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                account.AccountName = reader["AccountName"].ToString();
                account.AccountType = reader["AccountType"].ToString();
                account.Email = reader["Email"].ToString();
                account.PhoneNumber = reader["PhoneNumber"].ToString();
                account.Balance = Convert.ToSingle(reader["Balance"]);
                account.DateOfBirth = reader["DateOfBirth"].ToString();
                account.Address = reader["Address"].ToString();
                account.Occupation = reader["Occupation"].ToString();
                account.AccountOpeningDate = reader["AccountOpeningDate"].ToString();
                account.BranchName = reader["BranchName"].ToString();
                accounts.Add(account);
            }
            return accounts;
        }
        public List<Account> GetAccountByAccountNumber(int accountNumber)
        {
            string sql = "SELECT * FROM Accounts WHERE AccountNumber='" + accountNumber + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                account.AccountName = reader["AccountName"].ToString();
                account.AccountType = reader["AccountType"].ToString();
                account.Email = reader["Email"].ToString();
                account.PhoneNumber = reader["PhoneNumber"].ToString();
                account.Balance = Convert.ToSingle(reader["Balance"]);
                account.DateOfBirth = reader["DateOfBirth"].ToString();
                account.Address = reader["Address"].ToString();
                account.Occupation = reader["Occupation"].ToString();
                account.AccountOpeningDate = reader["AccountOpeningDate"].ToString();
                account.BranchName = reader["BranchName"].ToString();
                accounts.Add(account);
            }
            return accounts;
        }
        public List<Account> GetAccountByBranchName(string branchName)
        {
            string sql = "SELECT * FROM Accounts WHERE BranchName='" + branchName + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                account.AccountName = reader["AccountName"].ToString();
                account.AccountType = reader["AccountType"].ToString();
                account.Email = reader["Email"].ToString();
                account.PhoneNumber = reader["PhoneNumber"].ToString();
                account.Balance = Convert.ToSingle(reader["Balance"]);
                account.DateOfBirth = reader["DateOfBirth"].ToString();
                account.Address = reader["Address"].ToString();
                account.Occupation = reader["Occupation"].ToString();
                account.AccountOpeningDate = reader["AccountOpeningDate"].ToString();
                account.BranchName = reader["BranchName"].ToString();
                accounts.Add(account);
            }
            return accounts;
        }
        public List<Account> GetAccountByAccountType(string accountType)
        {
            string sql = "SELECT * FROM Accounts WHERE AccountType='" + accountType + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                account.AccountName = reader["AccountName"].ToString();
                account.AccountType = reader["AccountType"].ToString();
                account.Email = reader["Email"].ToString();
                account.PhoneNumber = reader["PhoneNumber"].ToString();
                account.Balance = Convert.ToSingle(reader["Balance"]);
                account.DateOfBirth = reader["DateOfBirth"].ToString();
                account.Address = reader["Address"].ToString();
                account.Occupation = reader["Occupation"].ToString();
                account.AccountOpeningDate = reader["AccountOpeningDate"].ToString();
                account.BranchName = reader["BranchName"].ToString();
                accounts.Add(account);
            }
            return accounts;
        }
        public int AddAccount(Account account)
        {
            string sql = "INSERT INTO Accounts(AccountName, AccountType, PhoneNumber, Email, Balance,DateOfBirth, Address, Occupation, AccountOpeningDate, BranchName) VALUES('" + account.AccountName + "','" + account.AccountType + "','" + account.PhoneNumber + "','" + account.Email + "','" + account.Balance + "','"+account.DateOfBirth+"','"+account.Address+"','"+account.Occupation+"','" + account.AccountOpeningDate + "','"+ account.BranchName +"')";
            return this.ExecuteQuery(sql);
        }

        public int UpdateAccount(Account account)
        {
            string sql = "UPDATE Accounts SET AccountName='" + account.AccountName + "',PhoneNumber='" + account.PhoneNumber + "', Email='" + account.Email + "', DateOfBirth='"+account.DateOfBirth+ "', Address='" + account.Address + "', Occupation='" + account.Occupation + "',BranchName='"+account.BranchName+"' WHERE AccountNumber='" + account.AccountNumber+ "'";
            return this.ExecuteQuery(sql);
        }
        public int UpdateBalance(Account account)
        {
            string sql = "UPDATE Accounts SET Balance='" + account.Balance + "' WHERE AccountNumber='" + account.AccountNumber + "'";
            return this.ExecuteQuery(sql);
        }
        public int DeleteAccount(int accountNumber)
        {
            string sql = "DELETE FROM Accounts WHERE AccountNumber='" + accountNumber + "'";
            return this.ExecuteQuery(sql);
        }
    }
}
