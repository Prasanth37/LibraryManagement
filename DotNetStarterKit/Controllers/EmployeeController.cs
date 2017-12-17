using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DotNetStarterKit.Domain;
using DotNetStarterKit.Models.Interfaces;

namespace DotNetStarterKit.Controllers
{
    public class EmployeeController : ApiController
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.ReadAll();
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]Employee employee)
        {
            _employeeRepository.Create(employee);
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
