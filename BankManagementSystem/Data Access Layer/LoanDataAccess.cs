using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankManagementSystem.Data_Access_Layer
{
    class LoanDataAccess:DataAccess
    {
        public List<Loan> GetLoans()
        {
            string sql = "SELECT * FROM Loans";
            SqlDataReader reader = this.GetData(sql);
            List<Loan> loans = new List<Loan>();
            while (reader.Read())
            {
                Loan loan = new Loan();
                loan.LoanType = reader["LoanType"].ToString();
                loan.Amount = Convert.ToSingle(reader["Amount"]);
                loan.LoanStartDate = reader["LoanStartDate"].ToString();
                loan.LoanEndDate = reader["LoanEndDate"].ToString();
                loan.PayAmount = Convert.ToSingle(reader["PayAmount"]);
                loan.PaymentDate = reader["PaymentDate"].ToString();
                loan.BranchName = reader["BranchName"].ToString();
                loan.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                loans.Add(loan);
            }
            return loans;
        }
        public List<Loan> GetLoanByAccountNumber(int accountNumber)
        {
            string sql = "SELECT * FROM Loans WHERE AccountNumber='" + accountNumber + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Loan> loans = new List<Loan>();
            while (reader.Read())
            {
                Loan loan = new Loan();
                loan.LoanType = reader["LoanType"].ToString();
                loan.Amount = Convert.ToSingle(reader["Amount"]);
                loan.LoanStartDate = reader["LoanStartDate"].ToString();
                loan.LoanEndDate = reader["LoanEndDate"].ToString();
                loan.PayAmount = Convert.ToSingle(reader["PayAmount"]);
                loan.PaymentDate = reader["PaymentDate"].ToString();
                loan.BranchName = reader["BranchName"].ToString();
                loan.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                loans.Add(loan);
            }
            return loans;
        }
        public List<Loan> GetLoanByBranchName(string branchName)
        {
            string sql = "SELECT * FROM Loans WHERE BranchName='" + branchName + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Loan> loans = new List<Loan>();
            while (reader.Read())
            {
                Loan loan = new Loan();
                loan.LoanType = reader["LoanType"].ToString();
                loan.Amount = Convert.ToSingle(reader["Amount"]);
                loan.LoanStartDate = reader["LoanStartDate"].ToString();
                loan.LoanEndDate = reader["LoanEndDate"].ToString();
                loan.PayAmount = Convert.ToSingle(reader["PayAmount"]);
                loan.PaymentDate = reader["PaymentDate"].ToString();
                loan.BranchName = reader["BranchName"].ToString();
                loan.AccountNumber = Convert.ToInt32(reader["AccountNumber"]);
                loans.Add(loan);
            }
            return loans;
        }
        public int AddLoan(Loan loan)
        {
            string sql = "INSERT INTO Loans(LoanType, Amount, LoanStartDate, LoanEndDate,PayAmount, PaymentDate, BranchName, AccountNumber) VALUES('" + loan.LoanType + "','" + loan.Amount + "','" + loan.LoanStartDate + "','" + loan.LoanEndDate + "','"+loan.PayAmount+"','"+loan.PaymentDate+"','"+loan.BranchName+"','" + loan.AccountNumber + "')";
            return this.ExecuteQuery(sql);
        }
        public int DeleteLoan(int accountNumber)
        {
            string sql = "DELETE FROM Loans WHERE AccountNumber='" + accountNumber + "'";
            return this.ExecuteQuery(sql);
        }
        public int UpdateLoan(Loan loan)
        {
            string sql = "UPDATE Loans SET PayAmount='"+loan.PayAmount+"',PaymentDate='"+loan.PaymentDate+"' WHERE AccountNumber='"+loan.AccountNumber+"'";
            return this.ExecuteQuery(sql);
        }
    }
}
