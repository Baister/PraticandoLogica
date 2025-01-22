/*Título Capitalizado:
Peça ao usuário para digitar uma frase e exiba-a com cada palavra iniciando em maiúscula.*/

using System.Globalization;

Console.WriteLine("\nTITULO CAPITALIZADOR 3000");
Console.WriteLine("-------------------------\n");

Console.WriteLine("Digite uma frase: ");
string? frase = Console.ReadLine().ToLower();
//É necessário o Tolower porque ele não funciona se estiverem em maiúsculas. Li isso num fórum.
//Foi necessário criar um TextInfo que é uma classe. A classe TextInfo define métodos que determinam a semântica de maiúsculas e minúsculas de acordo com a cultura..
TextInfo fraseCapitalizada = new CultureInfo("pt-BR",false).TextInfo;

Console.WriteLine(fraseCapitalizada.ToTitleCase(frase));