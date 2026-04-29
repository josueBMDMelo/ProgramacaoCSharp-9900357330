using System;
namespace Aula09_1;

public class Program
{
    public static void Main()
    {
        /*List<double> notasAlunos = new List<double>();
        notasAlunos.Add(2.6);
        notasAlunos.Add(10);
        notasAlunos.Add(6.5);
        notasAlunos.Add(9.98);
        foreach(double d in notasAlunos)
        {
            Console.WriteLine(d);
        }
        Console.WriteLine("----");
        notasAlunos.Remove(2.6);
        foreach (double d in notasAlunos)
        {
            Console.WriteLine(d);
        }*/

        /*int[] vetor = new int[10]; //vetor de tamanho 5
        Console.WriteLine("Tamanho do vetor: " + vetor.Length);*/

        /*List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        //Console.WriteLine("Tamanho da lista: " + list.Count);
        list.Add(5 - 3);        // 2
        list.Add(10 - 13);      // -3
        list.Remove(2);
        //Console.WriteLine("Tamanho da lista: " + list.Count);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }*/

        /*EXERCICIO: Criar uma lista de nomes de cursos no site do SENAC
         * Abra o site do senac e veja os cursos disponíveis.
         * Os cursos podem ser do tipo livre, técnico ou ensino superior.
         * Depois crie uma lista separada que irá contemplar os cursos de TI apenas.
         * Se houve algum curso da primeira lista que seja igual a um curso da
         * segunda lista, mostre isso em tela.
         *
         * SITE DO SENAC: https://www.sp.senac.br/
         *
         * List<string> cursos = new List<string>();
         * List<string> cursosTI = new List<string>();
         *
         * if(curso == cursoTI) Console.WriteLine("curso igual")*/
        List<string> cursos = new List<string>();
        cursos.Add("Contador de história");
        cursos.Add("Arranjos florais");
        cursos.Add("Aromaterapia");
        cursos.Add("Formação Excel do Básica ao Avançado");
        cursos.Add("Lei Geral de Proteção de Dados");
        cursos.Add("Práticas Meditativas");
        cursos.Add("Inteligência Artificial Descomplicada");
        cursos.Add("Pranayamas");
        cursos.Add("Massagem");
        cursos.Add("Programação em C#");

        List<string> cursosTI = new List<string>();
        cursosTI.Add("Programação em C#");
        cursosTI.Add("Formação Excel do Básica ao Avançado");
        cursosTI.Add("Desenvolvimento de Sistemas");
        cursosTI.Add("Inteligência Artificial Descomplicada");
        cursosTI.Add("Lei Geral de Proteção de Dados");

        for(int i = 0; i < cursos.Count; i++)
        {
            for(int j = 0; j < cursosTI.Count; j++)
            {
                if(cursos[i] == cursosTI[j])
                {
                    Console.WriteLine("Curso de {0} encontrados nas 2 listas", cursos[i]);
                }
            }
        }

        for (int i = 0; i < cursos.Count; i++)
        {
            if (cursosTI.Contains(cursos[i]))
            {
                Console.WriteLine(cursos[i] + " DUPLICADO!");
            }
        }
    }
}