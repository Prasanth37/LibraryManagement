using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetStarterKit.Domain;

namespace DotNetStarterKit.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        void Create(Employee b);
        Employee Read(Employee b);
        void Update(Employee b);
        void Delete(Employee b);
        IEnumerable<Employee> ReadAll();
    }
}
