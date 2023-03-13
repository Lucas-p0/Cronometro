using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 Segundos");
            Console.WriteLine("M = Minuto => 10m = 10 Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data.Substring(0, data.Length - 1));
            int multiplica = 1;

            if (tipo == 'm')
            {
                multiplica = 60;
            }
            if (tempo == 0)
            {
                System.Environment.Exit(0);
            }
            Start(tempo * multiplica);
        }

        static void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

        }
        static void Start(int tempo)
        {

            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual + "s");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contagem finalizada");
            Thread.Sleep(2500);
        }
    }
}