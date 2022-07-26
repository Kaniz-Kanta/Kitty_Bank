using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer.Entities
{
    class Loan
    {
        public string LoanType { get; set; }
        public float Amount { get; set; }
        public string LoanStartDate { get; set; }
        public string LoanEndDate { get; set; }
        public float PayAmount { get; set; }
        public string PaymentDate { get; set; }
        public string BranchName { get; set; }
        public int AccountNumber { get; set; }
    }
}
