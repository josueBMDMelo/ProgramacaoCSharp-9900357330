using System;
namespace Aula07_2;

public class Program
{
    public static void Main()
    {
        //ARRAY (VETOR)
        /*string nome1 = "João";
        string nome2 = "Paula";
        string nome3 = "Maria";
        string nome4 = "Roberto";

        string[] nomes = { "João", "Paula", "Maria", "Roberto" }; //declarando e atribuindo
        int[] numeros = new int[4]; //declarando (fixando tamanho do vetor)
        string[] palavras = new string[3];
        bool[] boolres = new bool[3];*/

        /*for(int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }*/

        /*for (int i = 0; i < boolres.Length; i++)
        {
            Console.WriteLine(boolres[i]);
        }*/
        /*numeros[0] = 10;
        numeros[2] = 30;
        numeros[3] = 40;
        Console.WriteLine(numeros[2]);
        Console.WriteLine(numeros.Length);*/


        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());
        int[] vet = new int[tamanho];
        Console.Write("Digite uma posição do vetor para atribuir um valor: ");
        int x = int.Parse(Console.ReadLine());
        if(x > 0 && x < tamanho)
        {
            Console.Write("Qual o valor você quer inserir nesta posição? ");
            int y = int.Parse(Console.ReadLine());
            vet[x] = y;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Vetor na posição {0}: {1}", i, vet[i]);
            }
        }
            



            /*for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            /* EXERCICIO: Dar a opção do usuário escrever os nomes de pessoas em um vetor (array)
             * usar Console.ReadLine();
             * 
             * Exemplo vetor declarado e atribuído:
             * string[] nomes = { "João", "Paula", "Maria", "Roberto" };
             * 
             * Exemplo vetor apenas declarado com tamanho fixo:
             * string[] nomes = new string[4];
             * 
             * print dos nomes na tela.
             */
        }
    }