using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ex003
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double CalcularDiagnoal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }




    }
}
