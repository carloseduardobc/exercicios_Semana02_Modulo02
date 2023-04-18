internal class Program
{
    private static void Main(string[] args)
    {
        
        // --------------------------------------------------------------------------------------------------------------
        // [M2S02] Ex 3 - Nome e Idade
        // Faça um programa que leia o nome e a idade do paciente e como resultado mostre o nome do paciente. 
        // E a mensagem se é menor ou maior de idade e se é idoso.
        // --------------------------------------------------------------------------------------------------------------
        
        string nome;
        int idade;

        Console.Write("Por favor, informe o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Informe a sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade > 0 && idade < 18)
        {
            Console.Write("O paciente " + nome + " tem " + idade + " anos e é menor de idade!");
        }
        else if (idade > 17  && idade < 60)
        {
            Console.Write("O paciente " + nome + " tem " + idade + " anos e é adulto!");
        }
        else if (idade > 59)
        {
            Console.Write("O paciente " + nome + " tem " + idade + " anos e idoso!");
        }
        else
        {
            Console.Write("A idade informada é inválida!");
        }



    }
}