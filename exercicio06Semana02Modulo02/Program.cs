// --------------------------------------------------------------------------------------------------------------
// [M2S02] Ex 6 - Separando palavras

// Separando palavras em uma lista
// 1 - Declare uma variável do tipo string chamada "frase" e atribua a ela a seguinte frase: "A linguagem de programação C# é muito poderosa".
// 2 - Em seguida, crie uma lista de string chamada palavras e separe as palavras em cada posição da lista.
// 3 - Depois, exiba apenas a palavra "poderosa" na tela.
// --------------------------------------------------------------------------------------------------------------

string frase = "A linguagem de programação C# é muito poderosa";

List<string> palavras = new List<string>(frase.Split(" "));

Console.WriteLine(palavras[palavras.Count - 1]);
Console.WriteLine(palavras[^1]);
string palavraPoderosa = palavras[palavras.Count - 1];
Console.WriteLine(palavraPoderosa);