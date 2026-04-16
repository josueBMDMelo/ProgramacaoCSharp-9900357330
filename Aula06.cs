using System;
namespace Aula06;

public class Program
{
    public static void Main()
    {
        //ESTRUTRAS DE REPETIÇÃO ENCADEADAS
        //Variavel que se chama "contador": i, j
        /*Console.WriteLine("Linha: i | Coluna: j");
        for (int i = 0; i <= 10; i++)
        {
            //Console.WriteLine(i);
            for(int j = 0; j <= 10; j++)
            {
                //Console.WriteLine(j);
                Console.WriteLine("Linha: " + i + " Coluna: " + j);
            }
        }*/
        /*Console.Write("A partir de qual tabuada você deseja apresentar? ");
        int minimo = int.Parse(Console.ReadLine());

        Console.Write("Até qual tabuada você deseja apresentar? ");
        int maximo = int.Parse(Console.ReadLine());
        for(int i = minimo; i <= maximo; i++)
        {
            Console.WriteLine("Tabuada do {0}", i);
            for(int j = 0; j <= 10; j++)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }
            Console.WriteLine("-----------------");
        }*/

        //EXERCICIO: Mostrem um retangulo de 4 linhas e 6 colunas usando
        //a estrutura de repetição encadeada (i, j)
        /*for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 6; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }*/

        /*for (int i = 1; i <= 3; i++)
        {
            int j = 5;
            Console.WriteLine("Número do evento: " + i);
            Console.WriteLine("Contagem regressiva:");
            while (j >= 0)
            {
                Console.WriteLine(j);
                j--;
            }
        }*/
        //substitua o while pelo for:
        /*for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Número do evento: " + i);
            Console.WriteLine("Contagem regressiva:");
            for (int j = 5; j >= 0; j--)
            {
                Console.WriteLine(j);
            }
        }*/

        for(int hora = 0; hora < 24; hora++)
        {
            for(int minuto = 0; minuto < 60; minuto += 15)
            {
                for (int segundo = 0; segundo < 60; segundo++)
                {
                    Console.WriteLine($"{hora:D2}:{minuto:D2}:{segundo:D2}");
                }  
            }
        }
        //EXERCICIO: criar uma estrutura de repetição para imprimir na tela
        //Dia, hora e minuto.
        //exemplo de como deve sair no console:
        //dia 01 08:00

    }
}
