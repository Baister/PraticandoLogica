/*Soma de Números:
Solicite ao usuário uma sequência de números (até ele digitar 0) e exiba a soma total.*/
Console.WriteLine("SOMADOR 2345678");
Console.WriteLine("---------------");

int soma = 0;
bool continuar = true;

do {
    Console.Write("Digite um número: ");
    int num = Convert.ToInt16(Console.ReadLine());
    soma += num;
    Console.WriteLine("Número adicionado. Caso desejar parar digite [0]");
    
    if (num == 0)
    {
        Console.WriteLine($"\nO resultado da soma dos números foi {soma}.");
        Console.WriteLine("\nFinalizando o programa... \n");
        continuar = false;
    }
}while(continuar);


