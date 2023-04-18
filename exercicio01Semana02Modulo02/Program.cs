internal class Exercicio01
{
    private static void Main(string[] args)
    {
        
        // --------------------------------------------------------------------------------------------------------------
        // [M2S02] Ex 1 - Soma de números
        // Crie um programa que solicite ao usuário que digite dois números inteiros e exiba a soma desses números na tela.
        // --------------------------------------------------------------------------------------------------------------
        
        int num01, num02, soma;

        Console.WriteLine ("Seja Bem Vindo!");
        Console.Write ("Informe um número: ");        
        num01 = int.Parse(Console.ReadLine());
        Console.Write ("Informe outro número: ");
        num02 = int.Parse(Console.ReadLine());
        soma = num01 + num02;
        
        Console.WriteLine ("A soma dos valores informador é: " + soma);
        
    }
}