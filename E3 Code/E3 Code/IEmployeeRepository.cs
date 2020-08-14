using System.Collections.Generic;

namespace E3_Code
{
    public interface IEmployeeRepository
    {
        void Save(Employee Emp);
        List<Employee> GetAll();
        decimal GetSalary(int Id);
    }
}
