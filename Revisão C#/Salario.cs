using System;

namespace Salario
{
    class Program
    {
            static void Main(string[] args)
            {
            	int aula;
				double valor, salario, desconto, resultado;
				Console.WriteLine("Digite suas hora/aula");
				aula = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite o valor hora/aula");
				valor = double.Parse(Console.ReadLine());
				Console.WriteLine("Digite o percentual de desconto do INSS");
				desconto = double.Parse(Console.ReadLine());
				salario = aula * valor;
				resultado = salario - ((desconto/100) * salario);
				Console.WriteLine("O seu salário é: " + resultado);
				Console.ReadKey();
            }
    }
}
