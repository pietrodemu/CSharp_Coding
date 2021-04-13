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
                Console.WriteLine($"Number {i+1}: ");
                var strInput = Console.ReadLine();
                input[i] = Convert.ToInt32(strInput);
                if (input[i] < min)
                    min = input[i];
                if (input[i] > max)
                    max = input[i];
                sum += input[i];
            }
            double avg = sum/(input.Length);
            Console.WriteLine("min: ", min);
            Console.WriteLine("max: ", max);
            Console.WriteLine($"avg: {avg:N2}");
        }
    }
}
