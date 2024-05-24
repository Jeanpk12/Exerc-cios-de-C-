using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Vamos somar dois números?");
            Console.WriteLine("Por favor, digite o primeiro valor:");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Muito bem!");
            Console.WriteLine("Agora digite o segundo valor:");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = primeiroValor + segundoValor;
            Console.WriteLine($"O resultado da soma foi {resultado}");            
        }
    }
}

// Podemos fazer algumas coisas com o Console

/*
    - Console.Write: Escreve algo no console sem pular para a próxima linha
    - Console.WriteLine: Escreve algo no console e pula para a próxima linha
    - Console.Read: Lê o próximo caractere do console
    - Console.ReadKey: Lê a próxima tecla pressionada no console
    - Console.ReadLine: Lê uma linha inteira do console   
*/
