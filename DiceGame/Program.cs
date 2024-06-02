using System;
using System.Threading;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numeroJogador;
            int pontuacaoJogador = 0;
            int numeroInimigo;
            int pontuacaoInimigo = 0;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Pressione qualquer tecla para jogar os dados");
                Console.ReadKey();
                numeroJogador = random.Next(1, 7);
                pontuacaoJogador += numeroJogador;
                Console.WriteLine($"O seu número é {numeroJogador}");
                Console.WriteLine("...");
                Thread.Sleep(1000);
                numeroInimigo = random.Next(1, 7);
                pontuacaoInimigo += numeroInimigo;
                Console.WriteLine($"O numero do adiversário foi {numeroInimigo}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Sua pontuação total foi {pontuacaoJogador}");
            Console.WriteLine($"A pontuação total do inimigo foi {pontuacaoInimigo}");

            Thread.Sleep(2000);
            Console.WriteLine("");

            if (pontuacaoJogador > pontuacaoInimigo)
            {
                Console.WriteLine("Você venceu!");
            } 
            else if (pontuacaoJogador == pontuacaoInimigo)
            {
                Console.Write("Vocês empataram!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }

            Console.ReadKey();
        }
    }
}
