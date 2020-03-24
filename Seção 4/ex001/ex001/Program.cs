using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados Primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados Segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());


            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.nome} é mais velha(o)");
            }
            else
            {
                Console.WriteLine($"{p2.nome} é mais velho(a)");
            }
            
        }
    }
}
