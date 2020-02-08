using System;

namespace ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro valor: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor: ");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }

        }
    }
}
