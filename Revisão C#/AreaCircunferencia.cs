using System;

namespace AreaCircunferencia
{
    class Program
    {
            static void Main(string[] args)
            {
                double raio, area;
	            Console.WriteLine("Digite o valor do raio da circunferência: ");
	            raio = double.Parse(Console.ReadLine());
	            area = 3.14 * Math.Pow(raio,2);
	            Console.WriteLine("A área da circunferência é: "+area);
	            Console.ReadKey();
            }
    }
}
