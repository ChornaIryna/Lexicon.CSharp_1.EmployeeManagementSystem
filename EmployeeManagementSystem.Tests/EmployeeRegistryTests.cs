namespace EmployeeManagementSystem.Tests
{
    public class EmployeeRegistryTests
    {
        [Fact]
        public void AddEmployee_Adds_EmployeeToList()
        {
            // Arrange
            List<Employee> employees = new();
            EmployeeRegistry registry = new();
            Employee employee = new("Test Employee", 10000);
            // Act
            registry.AddEmployee(employee);
            // Assert
            Assert.Contains(employee, registry.Employees);

        }
    }
}