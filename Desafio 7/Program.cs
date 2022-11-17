using System;

namespace Desafio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, valor4, soma, media;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");
            valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor");
            valor4 = Convert.ToDouble(Console.ReadLine());

            soma = valor1 + valor2 + valor3 + valor4;

            Console.WriteLine("A soma é:", soma);
            Console.WriteLine(soma);

            media = valor1 + valor2 + valor3 + valor4;
            media = media / 4;

            Console.WriteLine("A media é:", media);
            Console.WriteLine(media); 

        }
    }
}
