using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
        int opcao;
        double a=0, b=0;
        do{
        Console.WriteLine("O que deseja calcular?\n"+
        "1 - Soma"+
        "\n2 - Substração"+
        "\n3 - Multiplicação"+
        "\n4 - Divisão"+
        "\n5 - Resto da Divisão"+
        "\n6 - Dobro"+
        "\n7 - Quadrado"+
        "\n8 - Cubo"+
        "\n9 - Raiz Quadrada"+
        "\n0 - SAIR");
        opcao = int.Parse(Console.ReadLine());

    if(opcao > 0 && opcao <= 9){
        Console.WriteLine("Digite o valor");
        a = double.Parse(Console.ReadLine());
    }
    
    
    switch(opcao){
        case 1:
                Console.WriteLine("Digite o 2º valor");
                b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}",a,b,Soma(a,b));
            break;
        case 2:
                Console.WriteLine("Digite o 2º valor");
                b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}-{1}={2}",a,b,Subtracao(a,b));
            break;
        case 3:
                Console.WriteLine("Digite o 2º valor");
                b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{1}={2}",a,b,Multiplicacao(a,b));
            break;
        case 4:
                Console.WriteLine("Digite o 2º valor");
                b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}/{1}={2}",a,b,Divisao(a,b));
            break;
        case 5:
                Console.WriteLine("Digite o 2º valor");
                b = double.Parse(Console.ReadLine());

            Console.WriteLine("Resto da divisão de {0} por {1}= {2}",a,b,Resto(a,b));
            break;
        case 6:
            Console.WriteLine("Dobro de {0} = {1}",a, Dobro(a));
            break;
        case 7:
            Console.WriteLine("{0}² = {1}",a,Quadrado(a));
            break;
        case 8:
            Console.WriteLine("{0}³ = {1}",a,Cubo(a));
            break;
        case 9:
            Console.WriteLine("Raiz quadrada de {0} = {1}",a,raizQuadrada(a));
            break;
        case 0:          
            break; 
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    }while(opcao !=0);
    }
    static double Soma(double a, double b){
        return a+b;
    }
    static double Subtracao(double a, double b){
        return a-b;
    }
    static double Divisao(double a, double b){
        return a/b;
    }
    static double Multiplicacao(double a, double b){
        return a*b;
    }
    static double Resto(double a, double b){
        return a%b;
    }
    static double Dobro(double a){
        return a*2;
    }
    static double Quadrado(double a){
        return a*a;
    }
    static double Cubo(double a){
        return a*a*a;
    }
    static double raizQuadrada(double a){
        return Math.Sqrt(a);
    }
    }


}