using System;

namespace ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número que deseja verificar: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
