/*Verificação de Par ou Ímpar:
Solicite ao usuário um número e exiba se ele é par ou ímpar.*/

using System.Diagnostics.Contracts;

Console.WriteLine("\nPARIDADE 2000");
Console.WriteLine("-------------");

bool continuar = true;

do{
    Console.Write("Digite um número: ");
    var numero = Convert.ToInt16(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($"Como o número que escolheu foi {numero} ele é PAR!");
    } else 
    {
        Console.WriteLine($"Como o número que escolheu foi {numero} ele é ÍMPAR!");
    };
    Console.Write("\nPara SAIR do programa digite [0] caso contrário, pressione qualquer tecla ");
    string zero = Console.ReadLine();
    
    if (zero == "0")
    {
        continuar = false;
    };


}while(continuar);

Console.WriteLine("Programa finalizado.");
Console.WriteLine();