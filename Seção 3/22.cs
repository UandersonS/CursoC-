using System;

namespace ex022
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;//quadrado
                int terceiro = i * i * i;//cubo
                Console.WriteLine($"{primeiro}{segundo}{terceiro}");
            }
        }
    }
}
