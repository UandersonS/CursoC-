using System;
using System.Globalization;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é R${preco2}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}\n" );
            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
