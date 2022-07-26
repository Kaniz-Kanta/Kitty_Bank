using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using BankManagementSystem.Data_Access_Layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Business_Logic_Layer
{
    class LoanService
    {
        LoanDataAccess loanDataAccess;
        public LoanService()
        {
            this.loanDataAccess = new LoanDataAccess();
        }
        public List<Loan> GetAllLoans()
        {
            return this.loanDataAccess.GetLoans();
        }
        public List<Loan> GetLoanByAccountNumber(int accountNumber)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.loanDataAccess.GetLoanByAccountNumber(accountNumber);
        }
        public List<Loan> GetLoanByBranchName(string branchName)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.loanDataAccess.GetLoanByBranchName(branchName);
        }
        public int AddLoan(string loanType, float amount, string loanStartDate, string loanEndDate,float payAmount,string paymentDate,string branchName, int accountNumber)
        {
            Loan loan= new Loan()
            {
                LoanType = loanType,
                Amount = amount,
                LoanStartDate = loanStartDate,
                LoanEndDate = loanEndDate,
                PayAmount= payAmount,
                PaymentDate= paymentDate,
                BranchName= branchName,
                AccountNumber = accountNumber
            };
            return this.loanDataAccess.AddLoan(loan);
        }
        public int UpdateLoan(float payAmount, string paymentDate, int accountNumber)
        {
            Loan loan = new Loan()
            {
                PayAmount= payAmount,
                PaymentDate= paymentDate,
                AccountNumber = accountNumber
            };
            return this.loanDataAccess.UpdateLoan(loan);
        }
        public int DeleteLoan(int accountNumber)
        {
            return this.loanDataAccess.DeleteLoan(accountNumber);
        }

    }
}
