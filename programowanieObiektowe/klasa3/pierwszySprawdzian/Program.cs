using ConsoleApp6.model;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args) {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        using (var reader = new StreamReader("mock_workers.csv"))
        using (var csv = new CsvReader(reader, config))

        {
            var records = csv.GetRecords<workers>();

            var wynik = from x in records
                        where x.gender == "Female" && x.age > 24 && x.age < 51
                        select new { imie = x.first_name, nazwisko = x.last_name };

            
            foreach (var i in wynik)
            {
                Console.WriteLine("Imię: {0} \nNazwisko:{1}\n", i.imie, i.nazwisko);
            }
        }
    }

}