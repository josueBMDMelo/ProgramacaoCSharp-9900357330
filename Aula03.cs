using System;
using System.Transactions;
namespace Aula03;

public class Program
{
    public static void Main()
    {
        //OPERADORES RELACIONAIS E LÓGICOS

        //RELACIONAIS
        //Maior que >
        //Maior ou igual >=
        //Menor que <
        //Menor ou igual <=
        //Igual == (diferente do atribuição que é =)
        //Diferente !=

        /*int numero = 10;
        Console.WriteLine(numero > 5);
        Console.WriteLine(numero >= 11);
        Console.WriteLine(numero < 12);
        Console.WriteLine(numero <= 2);
        Console.WriteLine(numero == 10);
        Console.WriteLine(numero != 10);*/

        //LÓGICOS
        //&& E (AND)
        //|| OU (OR)
        //! NÃO (NOT)

        int idade = 18;
        bool temCNH = true;

        //Console.WriteLine(idade >= 18 && temCNH);

        //COMANDOS DE ESTRUTURAS CONDICIONAIS
        //SE - IF
        //SE-SENÃO - ELSE IF
        //SENÃO - ELSE

        /*if (idade >= 18 && temCNH)
        {
            Console.WriteLine("Pode dirigir");
        }*/

        bool nomeNaLista = true;
        bool temConvite = true;

        /*if(nomeNaLista || temConvite)
        {
            Console.WriteLine("Pode entrar na festa!");
        }*/

        bool temCarteira = false;

        /*if (!temCarteira)
        {
            Console.WriteLine("Não pode dirigir!");
        }*/

        temCarteira = true;

        /*if (temCarteira)
        {
            Console.WriteLine("Pode dirigir!");
        }
        else
        {
            Console.WriteLine("Não pode dirigir!");
        }*/



        //EXERCÍCIO: DIGA SE O NÚMERO É IMPAR OU PAR:
        /*int num = -10;
        if(num % 2 == 1)
        {
            Console.WriteLine("É ímpar");
        }
        else
        {
            Console.WriteLine("É par");
        }*/

        //EXERCICIO UNIDADE, DEZENA, CENTENA, MILHAR
        /*double num = 10;
        if (num < 10)
        {
            Console.WriteLine("É unidade");
        }
        else if (num < 100)
        {
            Console.WriteLine("É dezena");
        }
        else if (num < 1000)
        {
            Console.WriteLine("É centena");
        }
        else
        {
            Console.WriteLine("É milhar");
        }*/
        //EXERCÍCIO: VERIFICAR SE UM NÚMERO É NEGATIVO, POSITIVO OU ZERO:
        /*int num = -210;
        if(num < 0)
        {
            Console.WriteLine("Este número é negativo.");
        }
        else if (num > 0)
        {
            Console.WriteLine("Este número é positivo.");
        }
        else
        {
            Console.WriteLine("Este número é ZERO.");
        }*/

        //CURSOS DO SENAC: TI, ENFERMAGEM, MARKETING, FOTOGRAFIA
        //PERIODOS: MANHA, TARDE, NOITE
        //MATRICULA: ATIVA, NÃO ATIVA (true, false)

        string curso = "MARKETING";
        string periodo = "MANHA";
        bool matricula = true;

        if (curso == "TI" && periodo == "NOITE" && matricula)
        {
            Console.WriteLine("O aluno está matriculado no curso de TI à NOITE.");
        }
        else if (curso == "TI" && periodo == "NOITE" && !matricula)
        {
            Console.WriteLine("O aluno é do curso de TI à NOITE, mas está com problema na matrícula.");
        }
        else if (curso == "MARKETING" && periodo == "MANHA" && matricula)
        {
            Console.WriteLine("O aluno está matriculado no curso de MARKETING de MANHÃ.");
        }
    }
}
