using System.Collections.Generic;
namespace E3_Code
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        private static Dictionary<int, Employee> Employees;
        public FakeEmployeeRepository()
        {
            if (Employees == null)
            {
                 Employees = new Dictionary<int, Employee>();
                // Add some default employees to work with
                Employees.Add(1, new Employee
                {
                    Id = 1,
                    LastName = "Bishop",
                    FirstName = "Barb",
                    Salary = 100000.00M
                });
                Employees.Add(2, new Employee
                {
                    Id = 2,
                    LastName = "Bishop",
                    FirstName = "Dave",
                    Salary = 99999.00M
                });
            }
        }
       private int GetNextId()
        {
            int curMaxId = 0;
            foreach (KeyValuePair<int, Employee> keyValuePair in Employees)
            {
                if (keyValuePair.Key > curMaxId)
                {
                    curMaxId = keyValuePair.Key;
                }
            }
            return ++curMaxId;
        }
        public int Save(Employee Emp)
        {
            int Id = GetNextId();
            Emp.Id = Id;
            Employees.Add(Emp.Id, Emp);
            return Id;
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
        public Employee GetById(int Id)
        {
            Employee emp;
            bool ignore = Employees.TryGetValue(Id, out emp);
            return emp;
        }
    }
}
