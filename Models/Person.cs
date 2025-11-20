namespace SistemaGestionEmpleados.Models
{
    public abstract class Person
    {
        protected Guid Id { get; set; } = Guid.NewGuid();
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age { get; set; }

        public abstract void ShowInfo();

        
        public string GetFirstName() => FirstName;
        public string GetLastName() => LastName;
        public int GetAge() => Age;

        public void SetFirstName(string name) => FirstName = name;
        public void SetLastName(string lastName) => LastName = lastName;
        public void SetAge(int age) => Age = age;
    }
}
