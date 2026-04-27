using System;
namespace Aula05;

public class Program
{
    public static void Main()
    {
        /*ESTRUTURAS DE REPETIÇÃO
         while = enquanto
         do-while = faça-enquanto
         for = para
        */
        //declaração do contador:
        //int contador = 0;
        //int i = 0;

        /*int i = 1;
        while (i <= 5)
        {
            Console.WriteLine("Número: " + i);
            i++;
        }*/

        /*int i = 1;
        do
        {
            i++;
            Console.WriteLine("Número: " + i);
        } while (i <= 5);

        bool aceite = false;
        do
        {
            Console.WriteLine("Seja bem-vindo");
        }while (aceite);*/

        /*for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Posição do contador: " + i);
        }*/

        /*Console.WriteLine("----TABUADA----");
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        int resultado = 0;

        for (int i = 0; i <= 10; i++)
        {
            resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
            //Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
        }*/

        //EXERCÍCIO: Mostrar os números de 0 a 20 com o while
        //int i = 0;
        /*while (i <= 20)
        {
            Console.WriteLine(i);
            i++;
        }

        string senha = "12345";
        string tentativa = "";

        while(tentativa != senha)
        {
            Console.Write("Digite sua senha: ");
            tentativa = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido");*/

        //EXERCICIO: VERIFICAR QUAIS NUMEROS SÃO IMPARES E PARES NUMA LISTA DE 0 a 30.
        //E IMPRIMIR NA TELA.
        //USAR FOR, USAR MODULO (%)
        /*for (int i = 0; i <= 30; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Número " + i + " é par.");
            }
            else
            {
                Console.WriteLine("Número " + i + " é ímpar.");
                //Console.WriteLine("Número {0} é ímpar.", i);
            }
        }*/

        //FIBONACCI
        int n1 = 0;
        int n2 = 1;
        for(int i = 0; i < 10; i++)
        {
            int proximo = n1 + n2;
            Console.WriteLine("Sequência: " + n1 + " + " + n2 + " = " + proximo);
            n1 = n2;
            n2 = proximo;
        }

        //EXERCÍCIO: Transforme este FOR do Fibonacci em WHILE
    }
}
