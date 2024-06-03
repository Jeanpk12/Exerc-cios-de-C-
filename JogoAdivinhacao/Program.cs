using System;
using static System.Console;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            WriteLine("Bem-vindo ao jogo da adivinhação de números.");
            WriteLine("O número que você deve adivinhar está entre 1 e 10.");
            WriteLine("Se Você acertar o número misterioso você vence.");
            WriteLine("Digite qualquer tecla para começar");
            ReadKey();
            Game();

        }

        static void Game()
        {
            Clear();
            bool numeroCorreto = false;
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 11);
            int tentativas = 0;


            while (!numeroCorreto)
            {
                tentativas++;
                WriteLine("Digite o seu palpite:");
                int palpite = Convert.ToInt32(ReadLine());

                if (palpite > numeroAleatorio)
                {
                    WriteLine("O seu número é maior que o número misterioso");
                }
                else if (palpite < numeroAleatorio)
                {
                    WriteLine("O seu número é menor que o numero misterioso");
                }
                else
                {
                    WriteLine();
                    WriteLine($"você acertou em {tentativas} tentativas! O número misterioso era o {numeroAleatorio}");
                    numeroCorreto = true;
                }
            }
        }
    }
}
