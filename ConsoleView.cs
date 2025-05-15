namespace EmployeeManagementSystem;

class ConsoleView
{
    private readonly EmployeeRegistry registry = new();

    public void Run()
    {
        while (true)
        {
            ShowMenu();
            if (int.TryParse(Console.ReadLine().Trim(), out int choice))
            {
                HandleChoice(choice);
            }
            else
            {
                Console.WriteLine("Ogiltigt val.");
            }
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Lägg till anställd");
        Console.WriteLine("2. Skriv ut register");
        Console.WriteLine("3. Avsluta");
        Console.Write("Välj ett alternativ (Mata in 1, 2 eller 3): ");
    }

    private void HandleChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Employee employee = GetEmployeeData();
                if (employee != null)
                {
                    registry.AddEmployee(employee);
                }
                break;
            case 2:
                registry.PrintRegistry();
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Ogiltigt val.");
                break;
        }
    }

    private static Employee GetEmployeeData()
    {
        string name;
        do
        {
            Console.Write("Ange ett namn: ");
            name = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Ogiltigt namn.");
            }
        } while (string.IsNullOrEmpty(name));

        decimal salary;
        do
        {
            Console.Write("Ange lön: ");
            if (!decimal.TryParse(Console.ReadLine().Trim(), out salary))
            {
                Console.WriteLine("Ogiltig lön. Mata in ett tal i decimalform (ex.: 10,99).");
            }
        } while (salary <= 0);

        return new Employee(name, salary);
    }
}
