using System;

namespace ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Número que deseja verificar: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else if (num == 0)            {
                Console.WriteLine("NULO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }

        }
    }
}
