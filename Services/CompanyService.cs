using SistemaGestionEmpleados.Models;
namespace SistemaGestionEmpleados.Services;

public class CompanyService
{
    private readonly EmployeeService _employeeService = new EmployeeService();

    public void AddEmployee(Company company, Employee employee)
    {
        company.EmployeesList.Add(employee);
        Console.WriteLine("Employee successfully added.");
    }

    public void DeleteEmployee(Company company, string firstName, string lastName)
    {
        if (firstName == null) throw new ArgumentNullException(nameof(firstName));
        var employee = company.EmployeesList.FirstOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
        if (employee != null)
        {
            company.EmployeesList.Remove(employee);
            Console.WriteLine("Employee successfully deleted.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void ShowAllEmployees(Company company)
    {
        if (!company.EmployeesList.Any())
        {
            Console.WriteLine("There are no registered employees.");
            return;
        }

        foreach (var employee in company.EmployeesList) _employeeService.ShowInfo(employee);
    }

    public void UpdateEmployee(Company company, string idNumber, Employee newData)
    {
        var employee = company.EmployeesList.FirstOrDefault(e => e.IdNumber == idNumber);
        if (employee != null)
        {
            employee.FirstName = newData.FirstName;
            employee.LastName = newData.LastName;
            employee.Age = newData.Age;
            employee.Role = newData.Role;
            employee.Salary = newData.Salary;
            Console.WriteLine("Employee successfully updated.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public Employee? SearchEmployee(Company company, string idNumber)
    {
        return company.EmployeesList.FirstOrDefault(e => e.IdNumber == idNumber);
    }

    public void ShowEmployeesByRole(Company company, string role)
    {
        var employesRole = company.EmployeesList.Where(e => e.Role.Equals(role, StringComparison.OrdinalIgnoreCase));
        
        foreach (var employee in employesRole)_employeeService.ShowInfo(employee);
    }
}