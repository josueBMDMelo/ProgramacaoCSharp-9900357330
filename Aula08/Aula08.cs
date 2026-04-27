using System;
namespace Aula08;

public class Program
{
    public static void Main()
    {
        //VETOR
        /*string[] nomesVet = new string[4];

        nomesVet[0] = "Josué";
        nomesVet[1] = "Paula";
        nomesVet[2] = "Amanda";
        nomesVet[3] = "Henrique";

        Console.WriteLine("Impressão com vetor:");
        for (int i = 0; i < nomesVet.Length; i++)
        {
            Console.WriteLine(nomesVet[i]);
        }
        Console.WriteLine("---");

        //LISTAS
        List<string> nomes = new List<string>();

        nomes.Add("Josué");
        nomes.Add("Paula");
        nomes.Add("Amanda");
        nomes.Add("Henrique");

        Console.WriteLine("Impressão com lista:");
        foreach (string s in nomes)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---");

        nomesVet[2] = "";
        Console.WriteLine("Impressão com vetor:");
        for (int i = 0; i < nomesVet.Length; i++)
        {
            Console.WriteLine(nomesVet[i]);
        }
        Console.WriteLine("---");

        nomes.Remove("Josué");
        nomes.Remove("Paula");
        nomes.Remove("Amanda");
        nomes.Remove("Henrique");

        nomes.Clear();
        nomes.Add("Tawan");
        nomes.Insert(0,"Roberto");

        Console.WriteLine("Impressão com lista:");

        foreach (string s in nomes)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---");*/

        /*int[] vetor1 = { 1, 2, 3 };
        int[] vetor2 = { 10, 20, 30 };
        int[] vetor3 = new int[2];
        List<int[]> list = new List<int[]>();

        list.Add(vetor1);
        list.Add(vetor2);
        foreach (int[] i in list)
        {
            for(int j = 0; j < i.Length; j++)
            {
                Console.WriteLine(i[j]);
            }
        }*/

        //EXERCICIO: CRIAR UMA LISTA DE NOMES DE ESPORTES.
        //LISTA TEM QUE TER NO MÍNIMO 5 ELEMENTOS.
        //ADICIONAR MAIS 2 ELEMENTOS E REMOVER OUTROS 2.

        //esportes.Add("")
        //esportes.Remove("")
        //esportes.Insert(0, "");

        //Imprimir lista na tela antes das remoções e depois das remoções
        List<string> esportes = new List<string>();
        Console.WriteLine("\n");

    }
}