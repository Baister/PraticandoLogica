/*Tabuada de um Número:
Peça ao usuário um número e exiba a tabuada dele de 1 a 10.*/
Console.WriteLine("TABUADA 3000");
Console.WriteLine("------------");

bool continuar = true;

do{

    try {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt16(Console.ReadLine());

        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        };

        Console.Write("\nPara SAIR do programa digite [0] caso contrário, pressione qualquer tecla ");
        string zero = Console.ReadLine();
    
        if (zero == "0")
        {
            continuar = false;
        };
    }catch (FormatException){
        Console.WriteLine("Favor inserir um valor válido!");
    };

    Console.WriteLine();

} while(continuar);
