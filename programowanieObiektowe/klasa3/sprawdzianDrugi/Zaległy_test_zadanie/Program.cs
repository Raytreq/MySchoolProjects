using Zaległy_test_zadanie;
using System.Security.Cryptography.X509Certificates;
using Zaległy_test_zadanie.Model;

class Program
{
    public static void Main(string[] args)
    {
        var tablica = new string[]
        {
            "Dzwonek",
        };

        Rower Wynik = new Rower("Romet", 6, Typ.trekkingowy, 2999, tablica);
        Wynik.Display();

        Console.WriteLine(Wynik.ToString());
    }
}
