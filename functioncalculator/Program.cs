using System;

namespace functioncalculator
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

            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------");
            Console.WriteLine("Selecione a opção");
            int operacaoSelecionada = int.Parse(Console.ReadLine());

            switch (operacaoSelecionada)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro valor:");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Muito bem!");
            Console.WriteLine("Agora digite o segundo número:");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = primeiroValor + segundoValor;
            Console.WriteLine($"O resultado da soma foi {resultado}");

            Console.ReadKey();
            Menu();  
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro número:");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Muito Bem!");
            Console.WriteLine("Agora digite o segundo número:");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = primeiroValor - segundoValor;
            Console.WriteLine($"O resultado da subtração foi {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro número");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Muito bem!");
            Console.WriteLine("Agora digite o segundo número:");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = primeiroValor * segundoValor;
            Console.WriteLine($"O resultado da multiplicação foi {resultado}");

            Console.ReadKey(); 
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Por favor, digite o primeiro número");
            double primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Muito bem!");
            Console.WriteLine("Agora digite o segundo número:");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resultado = primeiroValor / segundoValor;
            Console.WriteLine($"O resultado da divisão foi {resultado}");

            Console.ReadKey(); 
            Menu();
        }

    }
}
