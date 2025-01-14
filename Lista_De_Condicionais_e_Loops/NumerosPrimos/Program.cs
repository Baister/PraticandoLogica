/*Números Primos:
Peça ao usuário um número e exiba se ele é primo ou não.*/
Console.WriteLine("\nVerificador de Números Primos");
Console.WriteLine("-----------------------------");

Console.Write("Digite o número: ");
int num = Convert.ToInt16(Console.ReadLine());

if (num > 1 && num % 2 != 0)
{

    Console.WriteLine($"Esse número {num} é primo!");
}
if (num == 2)
{
    Console.WriteLine($"Esse número {num} é primo!");
}
Console.WriteLine();