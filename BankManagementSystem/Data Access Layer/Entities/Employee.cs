using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer.Entities
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string JoiningDate { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Education { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public string Designation { get; set; }
        public string BranchName { get; set; }
    }
}
