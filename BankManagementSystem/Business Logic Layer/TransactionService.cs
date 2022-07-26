using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using BankManagementSystem.Data_Access_Layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Business_Logic_Layer
{
    class TransactionService
    {
        TransactionDataAccess transactionDataAccess;
        public TransactionService()
        {
            this.transactionDataAccess = new TransactionDataAccess();
        }
        public List<Transaction> GetAllTransactions()
        {
            return this.transactionDataAccess.GetTransactions();
        }
        public List<Transaction> GetTransactionByAccountNumber(int accountNumber)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.transactionDataAccess.GetTransactionByAccountNumber(accountNumber);
        }
        public List<Transaction> GetTransactionByBranchName(string branchName)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.transactionDataAccess.GetTransactionByBranchName(branchName);
        }
        public List<Transaction> GetTransactionByTransactionDate(string transactionDate)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.transactionDataAccess.GetTransactionByTransactionDate(transactionDate);
        }
        public int AddTransaction(string transactionType, float amount, string transactionDate, string branchName,string accountType, int accountNumber)
        {
            Transaction transaction = new Transaction()
            {
                TransactionType= transactionType,
                Amount= amount,
                TransactionDate = transactionDate,
                BranchName = branchName,
                AccountType= accountType,
                AccountNumber= accountNumber
            }; 
            return this.transactionDataAccess.AddTransaction(transaction);
        }
        public int DeleteTransaction(int accountNumber)
        {
            return this.transactionDataAccess.DeleteTransaction(accountNumber);
        }
    }
}
