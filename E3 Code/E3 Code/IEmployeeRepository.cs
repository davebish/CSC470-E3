using System.Collections.Generic;

namespace E3_Code
{
    public interface IEmployeeRepository
    {
        int Save(Employee Emp);
        List<Employee> GetAll();
        decimal GetSalary(int Id);
        Employee GetById(int Id);
    }
}
