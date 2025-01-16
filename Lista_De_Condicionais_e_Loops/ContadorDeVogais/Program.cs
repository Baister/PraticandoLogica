/*Contagem de Vogais em uma String:
Solicite ao usuário uma palavra ou frase e conte quantas vogais ela contém.*/

Console.WriteLine("\nCONTADOR DE VOGAIS 3000");
Console.WriteLine("-------------------------\n");

Console.WriteLine("Digite uma palavra ou frase e contarei as vogais!");
Console.Write("Digite: ");

string palavra = Console.ReadLine().ToLower(); //Convertendo para minúsculas para facilitar a verificação.

string vogais = "aeiou"; //Vogais para comparação.
int contador = 0; //Contador de vogais

// Percorre cada caractere da palavra digitada
for (int i = 0; i < palavra.Length; i++)
{
    if (vogais.Contains(palavra[i])) // Verifica se o caractere atual é uma vogal
    {
        contador++; // Incrementa o contador de vogais
    }
}
Console.WriteLine($"\nA palalvra ou frase digitada contém {contador} vogais.");

char letra = 'a';

if (vogais.Contains(letra))
{
    Console.WriteLine("A letra está na string");
}
else 
{
    Console.WriteLine("A letra não está na string.");
}