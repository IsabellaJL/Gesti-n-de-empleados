namespace DefaultNamespace;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}")
            Console.WriteLine($"Id Number: {IdNumber}")
    }
}