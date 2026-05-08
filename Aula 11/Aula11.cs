using System;
namespace Aula11;

/*EXERCICIO: Criar uma classe chamada Esporte que recebe o objeto da Classe Pessoa
 * Criação da classe: public class Esporte
 * atributos: 
 * - public string nome;
 * - public int maxJogadores;
 * - public List<Pessoa> jogadores = new List<Pessoa>();
 * 
 * Os métodos a serem criados são:
 * - adicionar jogadores
 * - listar nome dos jogadores
 * - iniciar jogo
 * */
public class Esporte
{
    public string nome;
    public int maxJogadores;
    public List<Pessoa> jogadores = new List<Pessoa>();

    //restante do código...
}
public class Pessoa
{
    //atributos: caracteristicas
    public string nome;
    public double altura;
    public int idade;

    //metodos: ações
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos e minha altura é {altura}m.");
    }
    public void Saudacao(Pessoa p)
    {
        Console.WriteLine($"Prazer em te conhecer, {p.nome}");
    }
    public static int SomaIdades(int idade1, int idade2)
    {
        return idade1 + idade2;
    }
}
public class Program
{
    public static void Main()
    {
        //Classe "Pessoa"
        //Objeto "pessoa"

        //PRIMEIRA PESSOA
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Robervaldo";
        pessoa1.idade = 140;
        pessoa1.altura = 3;
        pessoa1.Apresentar();

        //SEGUNDA PESSOA
        Pessoa pessoa2 = new Pessoa();
        pessoa2.nome = "Florência";
        pessoa2.idade = 130;
        pessoa2.altura = 5;
        pessoa2.Apresentar();

        pessoa1.Saudacao(pessoa2);
        pessoa2.Saudacao(pessoa1);

        int somaIdades = Pessoa.SomaIdades(pessoa1.idade, pessoa2.idade);
        Console.WriteLine($"A soma da idade de {pessoa1.nome} e {pessoa2.nome}"
            + $"é igual a {somaIdades} anos.");

        /*EXERCICIO: Criar uma classe chamada Esporte que recebe o objeto da Classe Pessoa
         * Criação da classe: public class Esporte
         * atributos: 
         * - public string nome;
         * - public int maxJogadores;
         * - public List<Pessoa> jogadores = new List<Pessoa>();
         * 
         * Os métodos a serem criados são:
         * - adicionar jogadores
         * - lista jogadores
         * - iniciar jogo
         * */
    }
}