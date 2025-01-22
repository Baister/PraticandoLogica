/*Reverso de uma String:
Solicite ao usuário uma palavra e exiba seu reverso*/

Console.WriteLine("REVERSE STRING 3000");
Console.WriteLine("-------------------");

Console.Write("Digite uma palavra e você verá o inverso: ");
string? palavra = Console.ReadLine();
string palavraReverse = "";

foreach(char letra in palavra.Reverse())
{
    palavraReverse += Convert.ToString(letra);
}
Console.WriteLine($"A palavra ao contrário fica: {palavraReverse}");