using System;
using System.Globalization;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do Dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares voce vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ValorConvertido(quantia, cotacao);

            Console.WriteLine("Valor pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
