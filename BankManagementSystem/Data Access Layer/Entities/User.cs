using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Data_Access_Layer.Entities
{
    class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RegistrationDate { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
    }
}
