using System; 
namespace Aula02; 

public class Program 
{ 
    public static void Main() 
    {
        int numero = 10; // Soma
        numero = numero + 5;
        Console.WriteLine(numero);
        // Forma simplificada
        numero += 3; Console.WriteLine(numero);
        // Subtração numero -= 2; Console.WriteLine(numero); // Multiplicação double resultado = numero * 2; Console.WriteLine(resultado); // Divisão resultado = numero / 2; Console.WriteLine(resultado); // Módulo (resto da divisão) int resto = numero % 2; Console.WriteLine(resto);
    }
}