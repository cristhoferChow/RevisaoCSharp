using System;

namespace Operacoes
{
    class Program
    {
            static void Main(string[] args)
            {
                double a,b,soma,subtracao,multiplicacao,divisao;
	            Console.WriteLine("Digite o primeiro valor: ");
	            a = double.Parse(Console.ReadLine());
	            Console.WriteLine("Digite o segundo valor: ");
	            b = double.Parse(Console.ReadLine());
	            soma = a + b;
	            subtracao = a - b;
	            multiplicacao = a * b;
	            divisao = a / b;
	            Console.WriteLine();
	            Console.WriteLine("Soma: "+soma);
	            Console.WriteLine("Subtração: "+subtracao);
	            Console.WriteLine("Multiplicação: "+multiplicacao);
	            Console.WriteLine("Divisão: "+divisao);
	            Console.ReadKey();
            }
    }
}
