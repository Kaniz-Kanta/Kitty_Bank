using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using BankManagementSystem.Data_Access_Layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Business_Logic_Layer
{
    class EmployeeService
    {
        EmployeeDataAccess employeeDataAccess;
        public EmployeeService()
        {
            this.employeeDataAccess = new EmployeeDataAccess();
        }
        public List<Employee> GetEmployeeByEmployeeId(int employeeId)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.employeeDataAccess.GetEmployeeByEmployeeId(employeeId);
        }
        public List<Employee> GetEmployeeByBranchName(string branchName)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.employeeDataAccess.GetEmployeeByBranchName(branchName);
        }
        public List<Employee> GetEmployeeByDesignation(string designation)
        {
            //AccountDataAccess accountDataAccess = new AccountDataAccess();
            //int userId = usersDataAccess.GetUserId(userName);
            //this.userDataAccess = new UserDataAccess();
            return this.employeeDataAccess.GetEmployeeByDesignation(designation);
        }
        public List<Employee> GetAllEmployees()
        {
            return this.employeeDataAccess.GetEmployees();
        }
        public int AddEmployee(string employeeName,string phoneNumber, string email, string dateOfBirth, string education, string address, float salary, string designation, string joiningDate, string branchName)
        {
            Employee employee= new Employee()
            {
                EmployeeName = employeeName,
                PhoneNumber = phoneNumber,
                Email = email,
                DateOfBirth = dateOfBirth,
                Education= education,
                Address = address,
                Salary=salary,
                Designation=designation,
                JoiningDate = joiningDate,
                BranchName = branchName
            };
            return this.employeeDataAccess.AddEmployee(employee);
        }
        public int UpdateEmployee(int employeeId, string employeeName, string phoneNumber, string email, string dateOfBirth, string education, string address, float salary, string designation,string branchName)
        {
            Employee employee = new Employee()
            {
                EmployeeId= employeeId,
                EmployeeName = employeeName,
                PhoneNumber = phoneNumber,
                Email = email,
                DateOfBirth = dateOfBirth,
                Education = education,
                Address = address,
                Salary = salary,
                Designation = designation,
                BranchName = branchName
            };
            return this.employeeDataAccess.UpdateEmployee(employee);
        }
        public int DeleteEmployee(int employeeId)
        {
            return this.employeeDataAccess.DeleteEmployee(employeeId);
        }
    }
}
