namespace EmployeeManagementSystem
{
    class EmployeeRegistry
    {
        private List<Employee> employees = new List<Employee>();

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
