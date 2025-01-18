/*
Contagem de Palavras:
Escreva uma função que receba uma frase e retorne o número de palavras nela.
*/


Console.WriteLine("\n\nCONTADOR DE PALAVRAS");
Console.WriteLine("--------------------\n");

Console.Write("Digite uma frase: ");
string frase = ContadorPalavra(Console.ReadLine());
Console.WriteLine(frase);



string ContadorPalavra(string frase)
{
    //Colocando o espaço, ele que delimitará quando uma palavra começa ou termina.
    string vazio = " ";

    //Contador necessário para verificar.
    int contador = 0;

    for (int i = 0; i < frase.Length; i++)
    {
        if(vazio.Contains(frase[i]))
        {
            contador++;
        }
    }
    return $"\nEssa frase tem {contador + 1} palavras.\n";
    
}

