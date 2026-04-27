using System;
using System.Globalization;
namespace Aula07;

public class Program
{
    public static void Main()
    {
        /*int, double, string, bool
        inteiro, decimal, literal, lógico

        INTEIROS
        int, byte, short, ushort, long, ulong, ETC

        DECIMAIS
        double, decimal, float

        LITERAL
        string, char

        LÓGICO
        bool
        */

        //DOUBLE NÃO É OBRIGATORIO O SUFIXO "d"
        /*double peso = 61.5;
        Console.WriteLine("Seu peso é {0}", peso);

        decimal salario = 1250.69m;
        Console.WriteLine("Seu salário é {0}", salario);

        float movimento = 3.5f;
        Console.WriteLine("Seu movimento é {0}",movimento);
        */

        //LITERAL
        /*string nome = "Josué";
        char letra = 'A';*/

        string nome;
        int idade;
        long cpf;
        string dataNascimento;
        decimal salario;
        string email;
        char estadoCivil; 
        //CASADO (C), SOLTEIRO (S), VIUVO (V), DIVORCIADO (D), UNIAO ESTAVEL (U);

        Console.WriteLine("--Cadastro de pessoas--");

        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Informe seu CPF: ");
        cpf = long.Parse(Console.ReadLine());

        Console.Write("Informa sua data de nascimento (dd/mm/aaaa): ");
        dataNascimento = Console.ReadLine();

        Console.Write("Informe seu salário: ");
        salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe seu e-mail: ");
        email = Console.ReadLine();

        Console.Write("Informe seu estado civil: ");
        estadoCivil = Console.ReadLine()[0];

        Console.Write($"Seus dados preenchidos foram: {nome}, {idade}, {cpf}, {dataNascimento}, " +
            $"{salario}, {email}, {estadoCivil}");

    }
}