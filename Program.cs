using SistemaGestionEmpleados.Models;
using SistemaGestionEmpleados.Services;
using SistemaGestionEmpleados.Utilities;

class Program
{
    static void Main()
    {
        Company company = new Company();
        CompanyService companyService = new CompanyService();

        bool running = true;

        while (running)
        {
            Administracion.MostrarTitulo("Company Menu");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show All Employees");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Add Client");
            Console.WriteLine("7. Show All Clients");
            Console.WriteLine("8. Exit");

            Administracion.MostrarSeparador();
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                    var employee = Administracion.CrearEmpleado();
                    companyService.AddEmployee(company, employee);
                    break;

                case "2":
                    companyService.ShowAllEmployees(company);
                    break;

                case "3":
                    Console.Write("Enter employee ID number: ");
                    string id = Console.ReadLine();
                    var emp = companyService.FindEmployee(company, id);

                    if (emp != null)
                    {
                        Administracion.MostrarTitulo("EMPLOYEE FOUND");
                        emp.ShowInfo();
                    }
                    else
                        Console.WriteLine("Employee not found.");
                    break;

                case "4":
                    Console.Write("Enter employee ID number to update: ");
                    string idToUpdate = Console.ReadLine();

                    var newData = Administracion.CrearEmpleado();
                    companyService.UpdateEmployee(company, idToUpdate, newData);
                    break;

                case "5":
                    Console.Write("Enter employee ID number to delete: ");
                    string idToDelete = Console.ReadLine();
                    companyService.DeleteEmployee(company, idToDelete);
                    break;

                case "6":
                    var client = Administracion.CrearCliente();
                    companyService.AddClient(company, client);
                    break;

                case "7":
                    companyService.ShowAllClients(company);
                    break;

                case "8":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Administracion.MostrarPie("Returning to menu...");
        }
    }
}
