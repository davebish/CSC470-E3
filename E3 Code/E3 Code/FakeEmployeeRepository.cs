using System.Collections.Generic;

namespace E3_Code
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();

        public FakeEmployeeRepository()
        {
            // Add some default employees to work with
            Employees.Add(1, new Employee { Id = 1, LastName = "Bishop", FirstName = "Barb",
                                            Salary = 100000.00M});
            Employees.Add(2, new Employee { Id = 2, LastName = "Bishop", FirstName = "Dave",
                                            Salary = 99999.00M});
        }
        public void Save(Employee Emp)
        {
            Employees.Add(Emp.Id, Emp);
        }
        public List<Employee> GetAll()
        {
            List<Employee> emps = new List<Employee>();
            foreach (KeyValuePair<int, Employee> emp in Employees)
            {
                emps.Add(emp.Value);
            }
            return emps;
        }
        public decimal GetSalary(int Id)
        {
            decimal salary = -1.0M;
            Employee emp;
            if (Employees.TryGetValue(Id, out emp))
            {
                salary = emp.Salary;
            }
            return salary;
        }
    }
}
