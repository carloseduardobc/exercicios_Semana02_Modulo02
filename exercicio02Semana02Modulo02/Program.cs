internal class Exercicio02
{
    private static void Main(string[] args)
    {
        
        // --------------------------------------------------------------------------------------------------------------
        // [M2S02] Ex 2 - Par ou ímpar
        // Crie um programa que solicite ao usuário que digite um número inteiro e exiba na tela se esse número é par ou ímpar.
        // --------------------------------------------------------------------------------------------------------------
                
        Console.WriteLine ("Digite um número para verificar se ele é ÍMPAR ou PAR: ");
        int numero = int.Parse(Console.ReadLine());

        if(numero % 2 == 0){
            Console.WriteLine ("O número é PAR!");
        }
        else{
            Console.WriteLine ("O número é ÍMPAR!");
        }        
        
    }
}