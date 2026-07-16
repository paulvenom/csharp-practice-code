using Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        var luna = new Dog("Luna", 6);
        Console.WriteLine(luna.Bark());
        Console.WriteLine(luna.ShowHumanAge());

        var bella = new Dog();
        bella.Name = "Bella";
        bella.Age = 5;

        Console.WriteLine(bella.Bark());
        Console.WriteLine(bella.ShowHumanAge());

    }
}