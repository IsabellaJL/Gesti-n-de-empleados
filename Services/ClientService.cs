namespace DefaultNamespace;
using SistemaGestionEmpleados.Models;
public class ClientService
{
    public void ShowInfo(Client client)
    {
        Console.WriteLine($"Client's name: {client.FirstName} {client.LastName}");
        Console.WriteLine($"Client's age: {client.Age}");
        Console.WriteLine($"Email: {client.Email}");
        Console.WriteLine($"Phone number: {client.PhoneNumber}");
        Console.WriteLine();
    }
}