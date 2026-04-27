using System;
namespace Aula04;

public class Program
{
    public static void Main()
    {
        //ESTRUTURAS CONDICIONAIS COMPOSTAS
        /*double nota = 12;
        if (nota < 0 || nota > 10) 
        {
            Console.WriteLine("Essa nota não existe"); 
        }
        else if (nota < 5)
        {
            Console.WriteLine("Reprovado");
        }
        else if (nota < 7)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }*/

        /*int opcao = 0;
        
        if (opcao==1)
        {
            Console.WriteLine("Débito selecionado");
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Crédito selecionado");
        }
        else if (opcao == 3)
        {
            Console.WriteLine("PIX selecionado");
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }*/
        //SWITCH - CASE
        /*Console.Write("Digite uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Débito selecionado");
                break;
            case "2":
                Console.WriteLine("Crédito selecionado");
                break;
            case "3":
                Console.WriteLine("PIX selecionado");
                break;
            case "4":
                Console.WriteLine("Voucher selecionado");
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }*/

        /*Console.Write("Digite uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Débito selecionado");
                break;
            case 2:
                Console.WriteLine("Crédito selecionado");
                break;
            case 3:
                Console.WriteLine("PIX selecionado");
                break;
            case 4:
                Console.WriteLine("Voucher selecionado");
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }*/

        /*Console.Write("Digite a nota do aluno: ");
        //double nota = Convert.ToDouble(Console.ReadLine());
        int nota = int.Parse(Console.ReadLine());
        
        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Essa nota não existe");
        }
        else if (nota < 5)
        {
            Console.WriteLine("Reprovado");
        }
        else if (nota < 7)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
        Console.WriteLine(nota);*/

        Console.WriteLine("Bem-vindo ao banco");
        Console.WriteLine("Digite a opção desejada:");
        Console.WriteLine("Opção 1: SALDO");
        Console.WriteLine("Opção 2: PAGAMENTOS");
        Console.WriteLine("Opção 3: SAQUE");
        Console.WriteLine("Opção 4: SAIR");

        int opcao = int.Parse(Console.ReadLine());
        int saldo = 100;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Seu saldo é: R$" + saldo);
                break;
            case 2:
                Console.WriteLine("Para quem você deseja pagar?");
                string pagador = Console.ReadLine();

                Console.WriteLine("Quanto deseja enviar?");
                int valor = int.Parse(Console.ReadLine());

                if (valor>saldo)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else
                {
                    saldo = saldo - valor;
                    Console.WriteLine("Saldo após movimentação: R$" + saldo);
                }
                break;
            case 3:
                Console.WriteLine("Quanto deseja sacar?");
                int saque = int.Parse(Console.ReadLine());

                if (saque > saldo)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else
                {
                    saldo = saldo - saque;
                    Console.WriteLine("Saldo após movimentação: R$" + saldo);
                }
                break;
            case 4:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;

        }
    }


}