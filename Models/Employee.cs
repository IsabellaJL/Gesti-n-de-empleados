namespace SistemaGestionEmpleados.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdNumber { get; set; }
    public byte Age  { get; set; }
    public string Role { get; set; }
    public double Salary { get; set; }
}