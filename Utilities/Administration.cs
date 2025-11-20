namespace SistemaGestionEmpleados.Utilities
{
    public static class Administration
    {
        public static Employee CrearEmpleado()
        {
            var emp = new Employee();

            Console.Write("First Name: ");
            emp.SetFirstName(Console.ReadLine());

            Console.Write("Last Name: ");
            emp.SetLastName(Console.ReadLine());

            Console.Write("Age: ");
            emp.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("ID Number: ");
            emp.IdNumber = Console.ReadLine();

            Console.Write("Role: ");
            emp.Role = Console.ReadLine();

            Console.Write("Salary: ");
            emp.Salary = decimal.Parse(Console.ReadLine());

            return emp;
        }

        public static Client CrearCliente()
        {
            var client = new Client();

            Console.Write("First Name: ");
            client.SetFirstName(Console.ReadLine());

            Console.Write("Last Name: ");
            client.SetLastName(Console.ReadLine());

            Console.Write("Age: ");
            client.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Email: ");
            client.Email = Console.ReadLine();

            Console.Write("Phone: ");
            client.PhoneNumber = Console.ReadLine();

            return client;
        }

        // UI helpers
        public static void MostrarTitulo(string titulo)
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine($"           {titulo.ToUpper()}");
            Console.WriteLine("======================================");
        }

        public static void MostrarPie(string pie)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(pie);
            Console.WriteLine("--------------------------------------\n");
        }

        public static void MostrarSeparador()
        {
            Console.WriteLine("======================================");
        }
    }
}
