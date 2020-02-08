using System;

namespace ex018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int entrada = 0;
            int saida = 0;
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    entrada = entrada + 1;
                }
                else
                {
                    saida = saida + 1;
                }
            }
            Console.WriteLine(entrada + " in");
            Console.WriteLine(saida + " out");
        }
    }
}
