using System;

namespace Ex3_NumericFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 123.456;
            Console.WriteLine($"Valuta: {number:C2}");
            Console.WriteLine($"Due cifre decimali: {number:N2}");
            Console.WriteLine($"Intero: {number:N0}");
            Console.WriteLine("Percentuale una cifra decimale: {0:P1}", number/100);
        }
    }
}
