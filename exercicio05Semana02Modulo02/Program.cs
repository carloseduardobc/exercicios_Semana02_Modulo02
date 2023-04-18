// --------------------------------------------------------------------------------------------------------------
// [M2S02] Ex 5 - Ordenando números

// Crie um programa que leia 4 números e faça a ordenação entre eles.
// Passo a passo:
// * Declare um array de inteiros chamado "numeros", que vai armazenar os 4 números digitados pelo usuário;
// * Com o laço for peça que o usuário digite cada um dos 4 números, armazenando-os no array "numeros" através da posição i;
// * Use o método Sort da classe Array para ordenar o array "numeros" em ordem crescente;
// * Imprima os números ordenados na tela, usando um novo laço for.
// --------------------------------------------------------------------------------------------------------------

Console.WriteLine("Bem vindo! Por favor informe 4 valores...");

int[] numeros = new int[4];

for(int i = 0; i < 4; i++)
{
    Console.Write("Informe o valor " + i + ": ");
    int n = int.Parse(Console.ReadLine());
    numeros[i] = n;
}

Console.WriteLine();

Array.Sort(numeros);
for(int i = 0; i < 4; i++)
{
    Console.WriteLine(numeros[i]);
}