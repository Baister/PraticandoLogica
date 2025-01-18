/*Maior entre Três Números:
Crie uma função que receba três números e retorne o maior deles.*/

using System.Collections;

Console.WriteLine("\nMAIOR ENTRE THREE NUMBERS!!!");
Console.WriteLine("------------------------------\n");

int[] numeros = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Digite o {i+1}º valor: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
};

int maior = numeros[0];
int menor = numeros[0];

foreach(int num in numeros)
{
    if(num > maior)
    {
        maior = num;
    };
    if (num < menor)
    {
        menor = num;
    };
};
Console.WriteLine($"O maior número é {maior} e o menor {menor}.");