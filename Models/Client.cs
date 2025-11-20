namespace SistemaGestionEmpleados.Models
{
    public class Client : Person
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Client: {GetFirstName()} {GetLastName()}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
    }
}
