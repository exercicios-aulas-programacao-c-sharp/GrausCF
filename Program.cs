using System;
/*
[console: GrausCF] Converta uma temperatura digitada pelo usuário em °C para °F.

°F = °C × 1,8 + 32

Ref.: https://pt.wikipedia.org/wiki/Celsius

°C = 0
0°C equivalem a 32°F
*/
namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausCelsius, grausFahenreit;
            
            Console.WriteLine("Informe um valor de temperatura em Celsius (°C)");

            grausCelsius = Convert.ToDouble(Console.ReadLine());
            grausFahenreit = grausCelsius * 1.8 + 32;

            Console.WriteLine($"{grausCelsius:N1}°C equivalem a {grausFahenreit:N1}°F");
        }
    }
}
