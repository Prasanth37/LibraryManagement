using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetStarterKit.Controllers;
using DotNetStarterKit.Tests.FakeRepositories;
using DotNetStarterKit.Domain;

namespace DotNetStarterKit.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        
        [TestMethod]
        public void ShouldAddEmployee()
        {
            //Arrange
            var employeeRepository = new FakeEmployeeRepository();
            var employeeController = new EmployeeController(employeeRepository);
            var employee = new Employee
            {
                Name = "Foo",
                Title = "Developer",
                Department = "Orders"
            };
            

            //Act
            employeeController.Post(employee);

            //Assert
            Assert.AreEqual(employeeController.Get().First(), employee);
        }
    }
}
