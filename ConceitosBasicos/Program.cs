﻿using ConceitosBasicos.ConceitosBasicos;

var tiposAnonimos = new TiposAnonimos();
tiposAnonimos.TesteTiposAnonimos();

#region ´Método Principal
/*public class Functions
{
    public static long Factorial(int n)
    {
        // Test for invalid input.
        if ((n < 0) || (n > 20))
        {
            return -1;
        }

        // Calculate the factorial iteratively rather than recursively.
        long tempResult = 1;
        for (int i = 1; i <= n; i++)
        {
            tempResult *= i;
        }
        return tempResult;
    }
}

class MainClass
{
    static int Main(string[] args)
    {
        // Test if input arguments were supplied.
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }

        // Try to convert the input arguments to numbers. This will throw
        // an exception if the argument is not a number.
        // num = int.Parse(args[0]);
        int num;
        bool test = int.TryParse(args[0], out num);
        if (!test)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }

        // Calculate factorial.
        long result = Functions.Factorial(num);

        // Print result.
        if (result == -1)
            Console.WriteLine("Input must be >= 0 and <= 20.");
        else
            Console.WriteLine($"The Factorial of {num} is {result}.");

        return 0;
    }
}
// If 3 is entered on command line, the
// output reads: The factorial of 3 is 6.

class Program
{
    static async Task<int> Main(string[] args)
    {
      //return 0;
      return await AsyncConsoleWork();
    }

    private static async Task<int> AsyncConsoleWork()
    {
        return 0;
    }
}

Declarações mais comuns do método Main
    static void Main(){}
    static int Main(){}
    static void Main(string[] args){}
    static int Main(string[] args){}
    static async Task Main(){}
    static async Task<int> Main() { }
    static async Task Main(string[] args) { }
    static async Task<int> Main(string[] args) { }
*/
#endregion

#region Instrução de Nível Superior

//Console.WriteLine("Hello World");

//using System.Text;

//StringBuilder builder = new();
//builder.AppendLine("The following arguments are passed:");

//foreach (var arg in args)
//{
//    builder.AppendLine($"Argument={arg}");
//}

//Console.WriteLine(builder.ToString());
//return 0;
#endregion