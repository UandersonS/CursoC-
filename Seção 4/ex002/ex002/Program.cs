using System;
using System.Globalization;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa s1 = new Pessoa();
            Pessoa s2 = new Pessoa();

            Console.WriteLine("Dados do Primeiro funcionário:");
            Console.Write("Nome: ");
            s1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            s1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionário:");
            Console.Write("Nome: ");
            s2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            s2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (s1.Salario + s2.Salario) / 2;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
