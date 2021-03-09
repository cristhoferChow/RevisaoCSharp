using System;

namespace InversaoVar
{
    class Program
    {
            static void Main(string[] args)
            {
                 
				int a, b, c=0;
	            Console.WriteLine("Digite o primeiro valor: ");
	            a = int.Parse(Console.ReadLine());
	            Console.WriteLine("Digite o segundo valor: ");
	            b = int.Parse(Console.ReadLine());
	            c = a;
	            a = b;
	            b = c;
	            Console.WriteLine("A = "+a+" e B: "+b);
	            Console.ReadKey(); 
            }
    }
}
