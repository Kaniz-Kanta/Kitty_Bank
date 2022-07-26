using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer.Entities
{
    class Transaction
    {
        public int TransactionCode { get; set; }
        public string TransactionType { get; set; }
        public float Amount { get; set; }
        public string TransactionDate { get; set; }
        public string BranchName { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
    }
}
