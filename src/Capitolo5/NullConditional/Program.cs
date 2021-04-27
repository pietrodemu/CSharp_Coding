using System;

namespace NullConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatore null conditional "?."
            string str = null; 
            // int len = str.Length; // NullReferenceException
            int? len = str?.Length;
            System.Console.WriteLine($"lunghezza: {len}");
        }
    }
}
