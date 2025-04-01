namespace EmployeeManagementSystem
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Namn: {Name}, Lön: {Salary:C}";
        }
    }
}
