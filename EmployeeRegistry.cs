namespace EmployeeManagementSystem
{
    public class EmployeeRegistry
    {
        private readonly List<Employee> employees = [];
        public IReadOnlyList<Employee> Employees => employees;

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void PrintRegistry()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Registret är tomt.");
            }
            else
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
