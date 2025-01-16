/*
Fatorial de um Número:
Crie uma função que calcule o fatorial de um número recebido como parâmetro.
*/

using System.Reflection.Metadata.Ecma335;

Console.WriteLine("\nFATORIAL PROGRAM");
Console.WriteLine("------------------\n");

bool continuar = true;
do {
    try {
        Console.Write("\nDigite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int fatorial (int num)
        {
            int multiplicando = 1;

            for (int i = 1; i <= num; i++)
            {
                
                multiplicando *= i;
            }
            int fatorial = multiplicando;
            return fatorial;
        };

        Console.WriteLine($"O fatorial de {num}! é igual a {fatorial(num)}.\n \n");
        
        Console.WriteLine("Se desejar parar digite [0], caso não, pressione qualquer tecla.");
        string parar = Console.ReadLine();
        if (parar == "0")
            {
                Console.WriteLine("\nFinalizando...\n");
                continuar = false;
            }
    } catch (FormatException) {
        Console.WriteLine("Favor inserir um valor válido!");
    }
    
}while (continuar);
