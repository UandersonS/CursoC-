using System;
using System.Globalization;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int codFun = int.Parse(Console.ReadLine());
            int valHora = int.Parse(Console.ReadLine());
            double sal = double.Parse(Console.ReadLine());
            double salario = valHora * sal;
            Console.WriteLine($"NUMBER = {codFun}");
            Console.WriteLine($"SALARY = {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
