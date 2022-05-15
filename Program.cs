using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double subt = num1 - num2;
            double mult = num1 * num2;
            double div = num1 / num2;
            double media = (num1 + num2)/2;

            Console.WriteLine($"A soma dos números {num1} e {num2} é {soma}.");
            Console.WriteLine($"A subtração dos números {num1} e {num2} é {subt}.");
            Console.WriteLine($"A divisão dos números {num1} e {num2} é {div}.");
            Console.WriteLine($"A multiplicação dos números {num1} e {num2} é {mult}.");
            Console.WriteLine($"A média dos números {num1} e {num2} é {media}.");
            
        }
    }
}
