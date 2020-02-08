using System;
using System.Globalization;
namespace ex020
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisão impossível");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1",CultureInfo.InvariantCulture));

                }
            }
        }
    }
}
