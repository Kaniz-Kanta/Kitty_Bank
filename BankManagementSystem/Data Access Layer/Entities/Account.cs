using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer.Entities
{
    class Account
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public float Balance { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public string AccountOpeningDate { get; set; }
        public string BranchName { get; set; }
    }
}
