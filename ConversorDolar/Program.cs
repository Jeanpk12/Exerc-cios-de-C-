using System;

namespace ConversorDolar
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
            Console.WriteLine("1 - Converter Reais para Dolar");
            Console.WriteLine("2 - Converter Reais para Euro");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("-------------------------------");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: ConverterDolar(); break;
                case 2: ConverterEuro(); break;
                case 3: Console.WriteLine("Finalizando"); break;
                default: Console.WriteLine("Opção Inválida"); break;
            }
        }

        static void ConverterDolar()
    {   
        Console.Clear();
        Console.WriteLine("Quantos R$ você gostaria de converter?");
        Console.WriteLine("Digite o valor:");
        double valorParaConversao =  double.Parse(Console.ReadLine());
        double cotacaoDolar = 5.14;
        double valorConvertido = Math.Round(valorParaConversao / cotacaoDolar, 2);
        Console.WriteLine("-------------------");
        Console.WriteLine($"R${valorParaConversao} convertido em dolar da, aproximadamente, U${valorConvertido}");
        Console.ReadKey();
        Menu();
    }

        static void ConverterEuro()
        {
            Console.Clear();
            Console.WriteLine("Quantos R$ você gostaria de converter?");
            Console.WriteLine("Digite o valor:");
            double valorParaConversao = double.Parse(Console.ReadLine());
            double cotacaoEuro = 5.57;
            double valorConvertido = Math.Round(valorParaConversao / cotacaoEuro, 2);
            Console.WriteLine("-------------------");
            Console.WriteLine($"R${valorParaConversao} convertido em Euro da, aproximadamente, €{valorConvertido}");
            Console.ReadKey();
            Menu();
        }
    }

}
