namespace SistemaGestionEmpleados.Models
{
    public class Employee : Person
    {
        public string IdNumber { get; set; }
        public string Role { get; set; }
        public decimal Salary { get; set; }

        private decimal CalculateBonus() => Salary * 0.10m;

        public override void ShowInfo()
        {
            Console.WriteLine($"Employee: {GetFirstName()} {GetLastName()}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Salary (with bonus): {Salary + CalculateBonus()}");
        }
    }
}
