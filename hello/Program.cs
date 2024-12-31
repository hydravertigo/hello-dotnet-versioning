namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var number = int.Parse(Console.ReadLine());

        Console.WriteLine("This is your number: " + number);
    }
}
