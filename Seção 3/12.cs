using System;

namespace ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double Total;
            if (codigo == 1)
            {
                Total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                Total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                Total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                Total = quantidade * 2.00;
            }
            else
            {
                Total = quantidade * 1.50;
            }
            Console.WriteLine($"Total: R$ {Total.ToString("F2")}");

        }
    }
}
