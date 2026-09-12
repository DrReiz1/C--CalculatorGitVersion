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

        int results = 0;

        Console.WriteLine("Select the logical operation you want to execute:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Remainder");
        Console.WriteLine("6. Exponentiation");
        Console.WriteLine("0. Exit");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option) // Com base no número escolhido, o código direciona para uma operação aritmética.
        {
            case 0:
            // Encerra o código de forma imediata. O [0] indica que o programa terminou sem erros.
            Environment.Exit(0); 
            break; // Termina o case do switch conforme a expressão "option"

            case 1:
            Console.WriteLine(number1 + number2);
            break;

            case 2:
            Console.WriteLine(number1 - number2);
            break;

            case 3:
            Console.WriteLine();
            results = number1 * number2;
            break;

            case 4:
            // Adicionando uma condicional para caso o número inserido for 0:
            if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por 0");
                }
                else
                {
                    Console.WriteLine((double)number1 / number2);
                }
            break;

            case 5:
             if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por 0");
                }
                else
                {
                    Console.WriteLine(number1 % number2);
                }
            break;

            case 6:
            // Math.Pow é um método de System.Math que permite que calculemos potências em C#
            Console.WriteLine((int)Math.Pow(number1, number2)); // O (int) evita que números quebrados corroam a lógica da operação
            break; 
        }

    }
}
