namespace SistemaGestionEmpleados.Models;

public class Employee : Person
{
    public string Role { get; set; }
    public decimal Salary { get; set; }
    public string IdNumber { get; set; }

}
