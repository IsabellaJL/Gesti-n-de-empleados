using SistemaGestionEmpleados.Models;
using SistemaGestionEmpleados.Services;

class Program
{
    static void Main()
    {
        Company company = new Company();
        CompanyService companyService = new CompanyService();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n========== COMPANY MENU ==========");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show All Employees");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Add Client");
            Console.WriteLine("7. Show All Clients");
            Console.WriteLine("8. Exit");
            Console.WriteLine("==================================");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddEmployee(company, companyService);
                    break;

                case "2":
                    companyService.ShowAllEmployees(company);
                    break;

                case "3":
                    SearchEmployee(company, companyService);
                    break;

                case "4":
                    UpdateEmployee(company, companyService);
                    break;

                case "5":
                    DeleteEmployee(company, companyService);
                    break;

                case "6":
                    AddClient(company, companyService);
                    break;

                case "7":
                    companyService.ShowAllClients(company);
                    break;

                case "8":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    //EMPLOYEE

    static void AddEmployee(Company company, CompanyService companyService)
    {
        Employee employee = new Employee();

        Console.Write("First Name: ");
        employee.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        employee.LastName = Console.ReadLine();

        Console.Write("ID Number: ");
        employee.IdNumber = Console.ReadLine();

        Console.Write("Age: ");
        employee.Age = int.Parse(Console.ReadLine());

        Console.Write("Role: ");
        employee.Role = Console.ReadLine();

        Console.Write("Salary: ");
        employee.Salary = decimal.Parse(Console.ReadLine());

        companyService.AddEmployee(company, employee);
    }

    static void SearchEmployee(Company company, CompanyService companyService)
    {
        Console.Write("Enter employee ID number: ");
        string id = Console.ReadLine();

        var employee = companyService.FindEmployee(company, id);

        if (employee != null)
        {
            EmployeeService showService = new EmployeeService();
            showService.ShowInfo(employee);
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    static void UpdateEmployee(Company company, CompanyService companyService)
    {
        Console.Write("Enter employee ID number to update: ");
        string id = Console.ReadLine();

        Employee newData = new Employee();

        Console.Write("New First Name: ");
        newData.FirstName = Console.ReadLine();

        Console.Write("New Last Name: ");
        newData.LastName = Console.ReadLine();

        Console.Write("New Age: ");
        newData.Age = int.Parse(Console.ReadLine());

        Console.Write("New Role: ");
        newData.Role = Console.ReadLine();

        Console.Write("New Salary: ");
        newData.Salary = decimal.Parse(Console.ReadLine());

        companyService.UpdateEmployee(company, id, newData);
    }

    static void DeleteEmployee(Company company, CompanyService companyService)
    {
        Console.Write("Enter first name: ");
        string name = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        companyService.DeleteEmployee(company, name, lastName);
    }

    //CLIENT 

    static void AddClient(Company company, CompanyService companyService)
    {
        Client client = new Client();

        Console.Write("First Name: ");
        client.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        client.LastName = Console.ReadLine();

        Console.Write("Age: ");
        client.Age = int.Parse(Console.ReadLine());

        Console.Write("Email: ");
        client.Email = Console.ReadLine();

        Console.Write("Phone Number: ");
        client.PhoneNumber = Console.ReadLine();

        companyService.AddClient(company, client);
    }
}
