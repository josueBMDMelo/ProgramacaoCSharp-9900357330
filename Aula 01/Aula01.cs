using System;

namespace Aula01;
public class Program
{
    public static void Main()
    {
        // Escreve uma mensagem com quebra de linha
        Console.WriteLine("Olá, meu nome é Josué");

        // Escreve sem quebrar linha
        Console.Write("Tenho ");
        Console.Write(26);
        Console.WriteLine(" anos");

        // Exibindo número diretamente
        Console.WriteLine(2026);

        // Concatenação (juntar texto + valor)
        Console.WriteLine("Minha idade é " + 26);

        // Comentário de uma linha
        // Console.WriteLine("Esse código não será executado");

        /*
           Comentário de várias linhas
           Tudo aqui dentro é ignorado pelo programa
        */
    }
}