using System.Collections.Generic;
using System.Linq;
using DotNetStarterKit.Domain;
using DotNetStarterKit.Models.Interfaces;

namespace DotNetStarterKit.Tests.FakeRepositories
{
    public class FakeEmployeeRepository: IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();
        public void Create(Employee e)
        {
            employees.Add(e);
        }

        public Employee Read(Employee b)
        {
            return employees.First(x => x.Id == b.Id);
        }

        public void Update(Employee e)
        {
            var employee = employees.First(x => x.Id == e.Id);
            employee.Name = e.Name;
            employee.Department = e.Department;
            employee.Title = e.Title;
        }

        public void Delete(Employee b)
        {
            employees.RemoveAll(x => x.Id == b.Id);
        }

        public IEnumerable<Employee> ReadAll()
        {
            return employees;
        }
    }
}
