using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {

            Start(6);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);
        }

        static void Start(int tempo)
        {

            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contagem finalizada");
            Thread.Sleep(2500);
        }
    }
}