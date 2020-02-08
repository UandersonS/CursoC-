using System;
using System.Globalization;

namespace ex014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua Senha: ");
            double s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (s != 2002)
            {
                Console.WriteLine("Senha Invalida");
                s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
