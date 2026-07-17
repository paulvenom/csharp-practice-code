internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();

        Console.WriteLine($"My name is {name}.");

        Console.WriteLine($"My age is {args[0]}.");

        Console.WriteLine("Program complete! Press any key to exit.");

        Console.ReadKey();
    }
}