using System;

namespace PromptParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // METODO INSERIMENTO PARAMETRI DA PROMPT:
            var nome = args[0];
            var cognome = args[1];
            var data = DateTime.Today;
            var ora = DateTime.Now;
            Console.WriteLine($"Ciao {nome} {cognome}, oggi e' il giorno {data:d} e sono le ore {ora:HH:mm:ss}.");
            Console.WriteLine("Premi un tasto per uscire");
            Console.ReadKey();

            // METODO CON INTERAZIONE UTENTE:
            // Console.WriteLine("Nome: ");
            // var nome = Console.ReadLine();
            // Console.WriteLine("Cognome: ");
            // var cognome = Console.ReadLine();
            // var data = DateTime.Today;
            // var ora = DateTime.Now;
            // Console.WriteLine($"Ciao {nome} {cognome}, oggi e' il giorno {data:d} e sono le ore {ora:HH:mm:ss}.");
            // Console.WriteLine("Premi un tasto per uscire");
            // Console.ReadKey();
        }
    }
}
