namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========CALCULATOR=========");
        Console.WriteLine("Insert the first number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert the second number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select the logical operation you want to execute:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Remainder");
        Console.WriteLine("6. Exponentiation");
        Console.WriteLine("0. Exit");
        int option = Convert.ToInt32(Console.ReadLine());

    }
}
