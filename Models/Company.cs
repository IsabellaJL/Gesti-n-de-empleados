namespace SistemaGestionEmpleados.Models;

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Employee> EmployeesList { get; set; } = new List<Employee>();
}