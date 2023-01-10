// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

Console.WriteLine("Hello, World!");
Console.WriteLine("Con este programa promediaremos la temperatura de lunes a domingo de x ciudad");
//Datos de entrada
double[] temperatura = new double[7];
double prom = 0;
double suma = 0;
string[] dia = new string[7];
//Procedimiento
for (int i = 0; i < dia.Length; i++)//Ciclo para capturar los días y temperatura de la semana. 
{
    Console.WriteLine($"Ingresa el día No. {i + 1}");
    dia[i] = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Captura la Temperatura °C");
    temperatura[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < temperatura.Length; i++)//un ciclo para acumular la temperatura de la semana
{
    suma = suma + temperatura[i];
    prom = suma / temperatura.Length;
}
Console.WriteLine("El promedio de la temperatura de la semana es " + prom + " °C");
