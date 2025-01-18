/*Palíndromo:
Escreva uma função que receba uma palavra e determine se ela é um palíndromo (lê-se da mesma forma de trás para frente).*/


Console.WriteLine("\n\nPALÍNDROMON");
Console.WriteLine("-------------\n\n");

Console.Write("Digite uma palavra e a função irá verificar se ela é um palíndromo ou não: ");
string? palavra = Palindromo(Console.ReadLine());

Console.WriteLine(palavra);

string Palindromo(string palavra)
{
    string palavraReversa = "";

    foreach(char letra in palavra.Reverse())
    {
        /* Fiz com que a variável palavraReversa adicionasse os caracteres para formar a palavra reversa!
        Console.Write(letra); */
        palavraReversa += Convert.ToString(letra);
    }
    //Console.WriteLine(palavraReversa); //Testando
    
    if (palavra == palavraReversa)
    {
        string resultado = ($"\nWOW! ESSA PALAVRA É UM PALÍNDROMO!!! É IGUAL DE TRÁS PRA FRENTE.\nVeja só: {palavra}, {palavraReversa}\n\n");

        return resultado;
    }
    else
    {
        string resultado = $"Elas não são palíndromos...\nAté porque elas são diferentes: {palavra} é diferente de {palavraReversa}\n\n";
        return resultado;
    };
};