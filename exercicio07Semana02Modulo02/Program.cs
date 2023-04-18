// --------------------------------------------------------------------------------------------------------------
// [M2S02] Ex 7 - Números pares

// Crie um programa que solicite ao usuário que insira um número inteiro positivo e exiba todos os
// números pares de 0 até esse número. Se o número digitado pelo usuário for negativo ou zero,
// exiba uma mensagem de erro e solicite novamente o número.

// Instruções:
// * Utilize as estruturas condicionais e laços de repetição;
// * Solicite ao usuário que informe um número inteiro positivo;
// * Se o número informado pelo usuário for menor ou igual a zero, o programa deve exibir uma
// mensagem de erro e solicita novamente que o usuário informe um número válido;
// * Após ter um número válido, use um laço de repetição for para percorrer todos os números pares
// de 0 até o número informado pelo usuário (incrementando de 2 em 2 a cada iteração) e exiba cada
// um dos números pares na tela;
// * Note que o programa não inclui o próprio número informado pelo usuário se ele for ímpar.
// Por exemplo, se o usuário informar o número 7, o programa exibirá apenas os números 0, 2, 4 e 6;
// --------------------------------------------------------------------------------------------------------------

int numero;

do{
    Console.Write("Informe um número: ");
    numero = int.Parse(Console.ReadLine());
    if (numero <= 0 ){
        Console.WriteLine("Valor inválido! Tente novamente...");
    }
} while(numero <= 0);

    for (int i = 0; i <= numero; i += 2){
        Console.WriteLine(i);
    }
