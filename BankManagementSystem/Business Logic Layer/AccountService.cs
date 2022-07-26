using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using BankManagementSystem.Data_Access_Layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Business_Logic_Layer
{
    class AccountService
    {
        AccountDataAccess accountDataAccess;
        public AccountService()
        {
            this.accountDataAccess = new AccountDataAccess();
        }
        public List<Account> GetAccountByPhoneNumber(string phoneNumber)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.accountDataAccess.GetAccountByPhoneNumber(phoneNumber);
        }
        public List<Account> GetAccountByAccountNumber(int accountNumber)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.accountDataAccess.GetAccountByAccountNumber(accountNumber);
        }
        public List<Account> GetAccountByBranchName(string branchName)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.accountDataAccess.GetAccountByBranchName(branchName);
        }
        public List<Account> GetAccountByAccountType(string accountType)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.accountDataAccess.GetAccountByAccountType(accountType);
        }
        public List<Account> GetAllAccounts()
        {
            return this.accountDataAccess.GetAccounts();
        }
        public int AddAccount(string accountName, string accountType,  string phoneNumber, string email, float balance,string dateOfBirth,string address, string occupation, string accountOpeningDate, string branchName)
        {
            Account account= new Account()
            {
                AccountName = accountName,
                AccountType= accountType,
                PhoneNumber = phoneNumber,
                Email = email,
                Balance = balance,
                DateOfBirth= dateOfBirth,
                Address= address,
                Occupation= occupation,
                AccountOpeningDate = accountOpeningDate,
                BranchName= branchName
            };
            return this.accountDataAccess.AddAccount(account);
        }
        public int UpdateAccount(int accountNumber, string accountName, string phoneNumber, string email, string dateOfBirth, string address, string occupation, string branchName)
        {
            Account account = new Account()
            {
                AccountNumber= accountNumber,
                AccountName = accountName,
                PhoneNumber = phoneNumber,
                Email = email,
                DateOfBirth = dateOfBirth,
                Address = address,
                Occupation = occupation,
                BranchName = branchName
            };
            return this.accountDataAccess.UpdateAccount(account);
        }

        //Deposite, withdraw, transfer
        public int UpdateBalance(int accountNumber,float balance)
        {
            Account account = new Account()
            {
                AccountNumber = accountNumber,
                Balance = balance
            };
            return this.accountDataAccess.UpdateBalance(account);
        }

        public int DeleteAccount(int accountNumber)
        {
            return this.accountDataAccess.DeleteAccount(accountNumber);
        }
    }
}
