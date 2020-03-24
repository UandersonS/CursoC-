using System;
using System.Globalization;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Largura e Altura do Retangulo");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {r.CalcularArea().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {r.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {r.CalcularDiagnoal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
