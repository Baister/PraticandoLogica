/*
Conversor de Temperatura:
Crie uma função que converta graus Celsius para Fahrenheit.
*/

Console.WriteLine("\n\nCONVERSOR DE TEMPERATURA 3000");
Console.WriteLine("-----------------------------");

Console.Write("\nDigite a temperatura em graus celsius: ");
double temperatura = ConversorDeTemperatura(Convert.ToDouble(Console.ReadLine()));

Console.WriteLine($"\nConvertendo para Fahrenheit: {temperatura}ºF\n\n");

double ConversorDeTemperatura(double temperatura)
{
    // convertendo para Fahrenheit

    //Fórmula para fahrenheit é F= 1.8 * C + 32
    double Fahrenheit = 1.8 * temperatura + 32;

    return Fahrenheit;

}