﻿using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {

        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cir = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PI: " + Pi);
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }

}
