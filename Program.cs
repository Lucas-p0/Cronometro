using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int tempo = 10;
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                tempoAtual++;
            }
        }
    }
}