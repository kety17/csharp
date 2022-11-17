using System;

namespace desafio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("informar se é inteiro ou real");

            try
            {
                Console.WriteLine("Digite um valor");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inteiro");
            }
            catch (FormatException)
            {
                Console.WriteLine("Real");





            }


        }
    }
}