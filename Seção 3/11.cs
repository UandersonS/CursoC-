using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {

            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}