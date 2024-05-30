using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor();
        }

        static void Conversor()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em celsius que deseja converter:");
            double temperatura = double.Parse(Console.ReadLine());
            double temperaturaConvertida = temperatura * (9.0/5.0) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é {temperaturaConvertida}");
        }
    }
}
