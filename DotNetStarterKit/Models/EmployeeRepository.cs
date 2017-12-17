using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DotNetStarterKit.Domain;
using DotNetStarterKit.Models.Interfaces;

namespace DotNetStarterKit.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private string _connectionString;
        public EmployeeRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
        }
        public void Create(Employee b)
        {
            throw new NotImplementedException();
        }

        public Employee Read(Employee b)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee b)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}