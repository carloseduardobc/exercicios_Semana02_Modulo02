// --------------------------------------------------------------------------------------------------------------
// [M2S02] Ex 4 - Informações de veículos
// Faça um programa que leia a Marca, Modelo e km rodados e mostre as informações do carro e se a KM for acima 10 mil,
// apresentar a mensagem que precisa ser feito uma revisão.
// --------------------------------------------------------------------------------------------------------------

Console.Write("Informe a Marca: ");
string marca = Console.ReadLine();
Console.Write("Informe a Modelo: ");
string modelo = Console.ReadLine();
Console.Write("Informe a KM: ");
float km = float.Parse(Console.ReadLine());

Console.Write("Seu veículo é um " + marca + " modelo " + modelo + " e está com " + km + " kms rodados! \n");

if (km > 10000)
{
    Console.WriteLine("Seu veículo precisa de revisão!");
}
