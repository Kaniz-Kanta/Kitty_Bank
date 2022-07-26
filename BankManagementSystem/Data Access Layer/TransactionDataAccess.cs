using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankManagementSystem.Data_Access_Layer
{
    class TransactionDataAccess:DataAccess
    {
        public List<Transaction> GetTransactions()
        {
            string sql = "SELECT * FROM Transactions";
            SqlDataReader reader = this.GetData(sql);
            List<Transaction> transactions = new List<Transaction>();
            while (reader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.TransactionCode = Convert.ToInt32(reader["TransactionCode"]);
                transaction.TransactionType = reader["TransactionType"].ToString();
                transaction.Amount= Convert.ToSingle(reader["Amount"]);
                transaction.TransactionDate = reader["TransactionDate"].ToString();
                transaction.BranchName = reader["BranchName"].ToString();
                transaction.AccountType= reader["AccountType"].ToString();
                transaction.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                transactions.Add(transaction);
            }
            return transactions;
        }
        public List<Transaction> GetTransactionByAccountNumber(int accountNumber)
        {
            string sql = "SELECT * FROM Transactions WHERE AccountNumber='" + accountNumber + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Transaction> transactions = new List<Transaction>();
            while (reader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.TransactionCode = Convert.ToInt32(reader["TransactionCode"]);
                transaction.TransactionType = reader["TransactionType"].ToString();
                transaction.Amount = Convert.ToSingle(reader["Amount"]);
                transaction.TransactionDate = reader["TransactionDate"].ToString();
                transaction.BranchName = reader["BranchName"].ToString();
                transaction.AccountType = reader["AccountType"].ToString();
                transaction.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                transactions.Add(transaction);
            }
            return transactions;
        }
        public List<Transaction> GetTransactionByBranchName(string branchName)
        {
            string sql = "SELECT * FROM Transactions WHERE BranchName='" + branchName + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Transaction> transactions = new List<Transaction>();
            while (reader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.TransactionCode = Convert.ToInt32(reader["TransactionCode"]);
                transaction.TransactionType = reader["TransactionType"].ToString();
                transaction.Amount = Convert.ToSingle(reader["Amount"]);
                transaction.TransactionDate = reader["TransactionDate"].ToString();
                transaction.BranchName = reader["BranchName"].ToString();
                transaction.AccountType = reader["AccountType"].ToString();
                transaction.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                transactions.Add(transaction);
            }
            return transactions;
        }
        public List<Transaction> GetTransactionByTransactionDate(string transactionDate)
        {
            string sql = "SELECT * FROM Transactions WHERE TransactionDate='" + transactionDate + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Transaction> transactions = new List<Transaction>();
            while (reader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.TransactionCode = Convert.ToInt32(reader["TransactionCode"]);
                transaction.TransactionType = reader["TransactionType"].ToString();
                transaction.Amount = Convert.ToSingle(reader["Amount"]);
                transaction.TransactionDate = reader["TransactionDate"].ToString();
                transaction.BranchName = reader["BranchName"].ToString();
                transaction.AccountType = reader["AccountType"].ToString();
                transaction.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                transactions.Add(transaction);
            }
            return transactions;
        }
        public int AddTransaction(Transaction transaction)
        {
            string sql = "INSERT INTO Transactions(TransactionType, Amount, TransactionDate, BranchName, AccountType, AccountNumber) VALUES('" + transaction.TransactionType + "','" + transaction.Amount + "','" + transaction.TransactionDate + "','" + transaction.BranchName + "','"+transaction.AccountType+"','" + transaction.AccountNumber + "')";
            return this.ExecuteQuery(sql);
        }
        public int DeleteTransaction(int accountNumber)
        {
            string sql = "DELETE FROM Transactions WHERE AccountNumber='" + accountNumber + "'";
            return this.ExecuteQuery(sql);
        }
    }
}
