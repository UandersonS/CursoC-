using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            double val1 = double.Parse(Console.ReadLine());
            int cod2 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double val2 = double.Parse(Console.ReadLine());
            double total = val1 * num1 + val2 * num2;
            Console.WriteLine($"VALOR A PAGAR: RS {total.ToString("F2")}");
        }
    }
}
