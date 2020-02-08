using System;
using System.Globalization;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int raio = int.Parse(Console.ReadLine());
            float area = 3.14159f * (raio * raio);
            Console.WriteLine($"A={area.ToString("F4")}", CultureInfo.InvariantCulture);
        }
    }
}
