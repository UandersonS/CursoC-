using System;
using System.Globalization;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            Console.WriteLine("Digite seu Nome:");
            fun.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu Salário Bruto");
            fun.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Imposto em cima do salário");
            fun.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionáio: {fun.Nome}, ${fun.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Digite a porcentagem para aumentar o salário");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            fun.AumentarSalario(porcent);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("DADOS DO FUNCIONÁRIO ATUALIZADO");
            Console.WriteLine($"Funcionáio: {fun.Nome}, ${fun.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

        }

    }
}
