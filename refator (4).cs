using System;

class CalculatorProgram
{
    public static void Main(string[] args)
    {
        double num1 = ReadDouble("Digite o 1º valor: ");
        double num2 = ReadDouble("Digite o 2º valor: ");
        char operation = ReadOperation();

        string errorMessage = "";
        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Operação: Adição");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Operação: Subtração");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Operação: Multiplicação");
                break;
            case '/':
                if (num2 == 0)
                {
                    errorMessage = "Não é possível dividir por zero.";
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("Operação: Divisão");
                }
                break;
            default:
                errorMessage = "Operação inválida.";
                break;
        }

        if (string.IsNullOrEmpty(errorMessage))
        {
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
        else
        {
            Console.WriteLine($"ERRO: {errorMessage}");
        }
    }

    private static double ReadDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value))
                return value;

            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }

    private static char ReadOperation()
    {
        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("+ para Adição");
        Console.WriteLine("- para Subtração");
        Console.WriteLine("* para Multiplicação");
        Console.WriteLine("/ para Divisão");
        
        while (true)
        {
            Console.Write("Operação: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && "+-*/".Contains(input.Trim()))
                return input.Trim()[0];

            Console.WriteLine("Operação inválida. Tente novamente.");
        }
    }
}
