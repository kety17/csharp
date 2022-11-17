using System;

namespace valor_a_b_c_equaçao_segundo_grau
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double delta;

            Console.WriteLine("Digite o valor de A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("O Resultado do Delta é {0}", delta);  
        }
    }
}
