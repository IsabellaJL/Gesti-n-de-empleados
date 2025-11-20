using SistemaGestionEmpleados.Models;
using SistemaGestionEmpleados.Services;

namespace SistemaGestionEmpleados.Services
{
    public class CompanyService
    {
        private readonly EmployeeService _employeeService = new EmployeeService();
        private readonly ClientService _clientService = new ClientService();

        // EMPLOYEES 

        public void AddEmployee(Company company, Employee employee)
        {
            company.EmployeesList.Add(employee);
            Console.WriteLine("Employee successfully added.");
        }

        public void DeleteEmployee(Company company, string idNumber)
        {
            var employee = company.EmployeesList
                .FirstOrDefault(e => e.IdNumber == idNumber);

            if (employee != null)
            {
                company.EmployeesList.Remove(employee);
                Console.WriteLine("Employee successfully removed.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void UpdateEmployee(Company company, string idNumber, Employee newData)
        {
            var employee = company.EmployeesList
                .FirstOrDefault(e => e.IdNumber == idNumber);

            if (employee != null)
            {
                employee.SetFirstName(newData.GetFirstName());
                employee.SetLastName(newData.GetLastName());
                employee.SetAge(newData.GetAge());
                employee.Role = newData.Role;
                employee.Salary = newData.Salary;

                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public Employee? FindEmployee(Company company, string idNumber)
        {
            return company.EmployeesList
                .FirstOrDefault(e => e.IdNumber == idNumber);
        }

        public void ShowAllEmployees(Company company)
        {
            if (!company.EmployeesList.Any())
            {
                Console.WriteLine("No employees registered.");
                return;
            }

            foreach (var emp in company.EmployeesList)
                _employeeService.ShowInfo(emp);
        }

        public void ShowEmployeesByRole(Company company, string role)
        {
            var employees = company.EmployeesList
                .Where(e => e.Role.Equals(role, StringComparison.OrdinalIgnoreCase));

            foreach (var emp in employees)
                _employeeService.ShowInfo(emp);
        }

        //CLIENTS 

        public void AddClient(Company company, Client client)
        {
            company.ClientsList.Add(client);
            Console.WriteLine("Client successfully added.");
        }

        public void DeleteClient(Company company, string email)
        {
            var client = company.ClientsList
                .FirstOrDefault(c => c.Email == email);

            if (client != null)
            {
                company.ClientsList.Remove(client);
                Console.WriteLine("Client removed successfully.");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }

        public void ShowAllClients(Company company)
        {
            if (!company.ClientsList.Any())
            {
                Console.WriteLine("No clients registered.");
                return;
            }

            foreach (var client in company.ClientsList)
                _clientService.ShowInfo(client);
        }
    }
}
