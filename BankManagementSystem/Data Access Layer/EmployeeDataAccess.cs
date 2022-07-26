using System;
using BankManagementSystem.Data_Access_Layer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankManagementSystem.Data_Access_Layer
{
    class EmployeeDataAccess:DataAccess
    {
        public List<Employee> GetEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee= new Employee();
                employee.EmployeeId= Convert.ToInt32(reader["EmployeeId"]);
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employee.JoiningDate = reader["JoiningDate"].ToString();
                employee.Designation = reader["Designation"].ToString();
                employee.BranchName= reader["BranchName"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public List<Employee> GetEmployeeByEmployeeId(int employeeId)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeId='" + employeeId + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employee.JoiningDate = reader["JoiningDate"].ToString();
                employee.Designation = reader["Designation"].ToString();
                employee.BranchName = reader["BranchName"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public List<Employee> GetEmployeeByBranchName(string branchName)
        {
            string sql = "SELECT * FROM Employees WHERE BranchName='" + branchName + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employee.JoiningDate = reader["JoiningDate"].ToString();
                employee.Designation = reader["Designation"].ToString();
                employee.BranchName = reader["BranchName"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public List<Employee> GetEmployeeByDesignation(string designation)
        {
            string sql = "SELECT * FROM Employees WHERE Designation='" + designation + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employee.JoiningDate = reader["JoiningDate"].ToString();
                employee.Designation = reader["Designation"].ToString();
                employee.BranchName = reader["BranchName"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public int AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(EmployeeName,PhoneNumber, Email, DateOfBirth, Education, Address,Salary, Designation, JoiningDate, BranchName) VALUES('" + employee.EmployeeName + "','" + employee.PhoneNumber + "','" + employee.Email + "','" + employee.DateOfBirth + "','" + employee.Education + "','" + employee.Address + "','" + employee.Salary + "','" + employee.Designation + "','" + employee.JoiningDate + "','" + employee.BranchName + "')";
            return this.ExecuteQuery(sql);
        }

        public int UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE Employees SET EmployeeName='" + employee.EmployeeName + "', PhoneNumber='" + employee.PhoneNumber + "',Email='" + employee.Email + "', DateOfBirth='" +employee.DateOfBirth + "',Education='" + employee.Education + "', Address='" +employee.Address+ "',Salary='" + employee.Salary+ "', Designation='" + employee.Designation + "',BranchName='" + employee.BranchName + "' WHERE EmployeeId='" + employee.EmployeeId+ "'";
            return this.ExecuteQuery(sql);
        }
        public int DeleteEmployee(int employeeId)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId='" + employeeId + "'";
            return this.ExecuteQuery(sql);
        }
    }
}
