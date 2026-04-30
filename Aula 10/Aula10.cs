using System;
using System.Globalization;
namespace Aula10;

public class Program
{
    public static void MostrarMensagem()
    {
        Console.WriteLine("Olá Mundo!");
    }
    public static void MostrarOutraMensagem()
    {
        MostrarMensagem();
        Console.WriteLine("Hello World!");
    }
    public static int MostrarNumeros()
    {
        return 10;
    }

    public static string MostrarTextos()
    {
        return "Hola Mundo!";
    }

    public static double Soma(double a, double b)
    {
        return a + b;
    }

    public static double Subtracao(double a , double b)
    {
        return a - b;
    }

    public static double Multiplicacao(double a, double b)
    {
        return a * b;
    }
    public static double Divisao(double a, double b)
    {
        return a / b;
    }
    public static double RestoDivisao(double a, double b)
    {
        return a % b;
    }

    public static void SomaVoid(double a, double b)
    {
        Console.WriteLine(a + b);
    }

    public static void Main()
    {
        //formas de chamar um método
        /*MostrarMensagem();
        MostrarOutraMensagem();
        int num = MostrarNumeros();
        Console.WriteLine(num);
        Console.WriteLine(MostrarTextos());*/

        //Parametros dos métodos. Ex.: metodo(int a)
        /*Console.WriteLine(Soma(1, 2));
        SomaVoid(1,2);*/

        //método e return devem ser do mesmo tipo sempre
        //os parametros não necessariamente precisam ser do mesmo tipo

        //variaveis para operações aritmeticas
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Soma: " + Soma(a, b));
        Console.WriteLine("Subtração: " + Subtracao(a, b));
        Console.WriteLine("Multiplicação: " + Multiplicacao(a, b));
        Console.WriteLine("Divisão: " + Divisao(a, b));
        Console.WriteLine("Resto da Divisão: " + RestoDivisao(a, b));

        /*EXERCICIO:
         * Crie um programa que funcione como uma CALCULADORA SIMPLES, 
         * utilizando métodos de cálculos aritméticos que já criamos.
            Faça um menu com opções. EX.:
            1 - Soma
            2 - Subtração
            3 - Multiplicação
            4 - Divisão
            5 - Resto da Divisão

            Faça variáveis na entrada, para que o usuário possa fornecer valores para serem calculados:
            Ex.: double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         */
    }
}