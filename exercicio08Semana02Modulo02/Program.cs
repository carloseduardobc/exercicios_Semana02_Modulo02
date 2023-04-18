// --------------------------------------------------------------------------------------------------------------
// [M2S02] Ex 8 - O maior número da lista

// Imprima o maior número da lista

// Crie um programa que solicite ao usuário que digite cinco números inteiros e armazene esses
// números em um array. Em seguida, exiba na tela o maior número digitado.
// --------------------------------------------------------------------------------------------------------------

Console.WriteLine("\n Por favor, informe 5 valores \n");

int n, n1 = 0;

int[] maior = new int[5];

for(int i = 0; i < maior.Length; i++)
{    

    Console.Write("Informe o valor: ");
    n = int.Parse(Console.ReadLine());
    
    if (n > n1)
    {
        Console.WriteLine("O número informado é o maior");
        n1 = n;        
    } else{
        Console.WriteLine("O número informado é menor");
        n = n1;        
    }

    Console.WriteLine("O maior valor informado foi: " + n1 + "\n");

}    