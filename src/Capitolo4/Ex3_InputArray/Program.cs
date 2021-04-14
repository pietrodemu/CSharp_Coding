using System;

namespace Ex3_InputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 0, sum = 0;
            Console.WriteLine("Please, insert 5 integer: ");
            int[] input = new int[5];
            for(var i=0; i<input.Length; i++)
            {
                // Recupero il valore
                Console.Write($"Number {i+1}: ");
                var intInput = int.Parse(Console.ReadLine());
                input[i] = intInput;

                // Operatori di confronto
                if (i == 0) 
                {
                    min = intInput;
                    max = intInput;
                }
                else
                {
                    if (intInput < min)
                        min = intInput;
                    if (intInput > max)
                        max = intInput;
                }
                sum += intInput;
            }
            double avg = sum/(input.Length);
            Console.WriteLine($"min: {min}");
            Console.WriteLine($"max: {max}");
            Console.WriteLine($"avg: {avg:N2}");
        }
    }
}
