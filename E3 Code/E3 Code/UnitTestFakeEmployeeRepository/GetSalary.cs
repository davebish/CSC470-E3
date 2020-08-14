using E3_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFakeEmployeeRepository
{
    [TestClass]
    public class GetSalary
    {
        [TestMethod]
        public void GetSalaryWithGoodIdIsCorrect()
        {
            // Arrange
            const int ID = 1;
            const decimal EXPECTED_SALARY = 100000.00M;
            FakeEmployeeRepository EmpRepository = new FakeEmployeeRepository();

            // Act
            decimal ActualSalary = EmpRepository.GetSalary(ID);

            // Assert
            Assert.AreEqual(EXPECTED_SALARY, ActualSalary);
        }
    }
}
