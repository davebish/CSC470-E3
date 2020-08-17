using E3_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFakeEmployeeRepository
{
    [TestClass]
    public class Save
    {
        [TestMethod]
        public void SaveEmployeeWorks()
        {
            // Arrange
            const string FIRST_NAME = "Test";
            const string LAST_NAME = "Case";
            const decimal SALARY = 9999.99M;
            FakeEmployeeRepository EmpRepository = new FakeEmployeeRepository();

            // Act
            Employee emp = new Employee();
            emp.FirstName = FIRST_NAME;
            emp.LastName = LAST_NAME;
            emp.Salary = SALARY;
            int id = EmpRepository.Save(emp);
            Employee newEmp = EmpRepository.GetById(id);

            // Assert
            Assert.IsTrue(emp.FirstName == newEmp.FirstName &&
                          emp.LastName == newEmp.LastName &&
                          emp.Salary == newEmp.Salary);
        }
    }
}
