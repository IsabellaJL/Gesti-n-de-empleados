using SistemaGestionEmpleados.Models;
namespace SistemaGestionEmpleados.Services;

public class EmployeeService
{
    private decimal CalculateBonus(Employee employee)
    {
        return employee.Salary * 0.10;
    }

    public void ShowInfo(Employee employee)
    {
        decimal salaryPlusBonus = employee.Salary + CalculateBonus(employee);
        Console.WriteLine($"Employee's name: {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Employee's age: {employee.Age}");
        Console.WriteLine($"Employee's Role: {employee.Role}");
        Console.WriteLine($"Employee's Salary: {salaryPlusBonus}");
    }
}
