

using DapperRainbowCRUD.Model;
using System.Data.Common;
using System.Data.SqlClient;

class Program
{
    static string ConnectionString = @"Server=localhost;Database=test;Trusted_Connection=True;";

    private static List<Master> GetAllMasters()
    {
        using (DbConnection connection = new SqlConnection(ConnectionString))
        {
            var db = RainbowDatabase.Init(connection, commandTimeout: 2);

            List<Master> masters = db.MasterTable.All().ToList();

            return masters;
        }
    }

    private static Master GetMaster(int id)
    {
        using (DbConnection connection = new SqlConnection(ConnectionString))
        {
            var db = RainbowDatabase.Init(connection, commandTimeout: 2);

            Master master = db.MasterTable.Get(id);

            return master;
        }
    }

    private static void InsertSingleMaster(string name)
    {
        using (DbConnection connection = new SqlConnection(ConnectionString))
        {
            var db = RainbowDatabase.Init(connection, commandTimeout: 2);

            Master master = new Master()
            {
                Name = name
            };

            Console.WriteLine(master.Id + " " + master.Name);
            db.MasterTable.Insert(master);
        }
    }

    private static void UpdateSingleMaster(int id, string name)
    {
        using (DbConnection connection = new SqlConnection(ConnectionString))
        {
            var db = RainbowDatabase.Init(connection, commandTimeout: 2);

            Master book = new Master { Id = id, Name = name };
            db.MasterTable.Update(id, book);
        }
    }

    private static void DeleteSingleMaster(int id)
    {
        using (DbConnection connection = new SqlConnection(ConnectionString))
        {
            var db = RainbowDatabase.Init(connection, commandTimeout: 2);
            db.MasterTable.Delete(id);
        }
    }

    public static void Main()
    {

        while (true)
        {

            Console.WriteLine("\n\n1 - Wyświetl, 2 - Dodaj, 3 - Zamień, 4 - Usuń, 0 - Wyjdź > ");
            string input = Console.ReadLine();

            switch(input.Trim())
            {
                case "0":
                    return;
                case "1":
                    {
                        List<Master> masters = GetAllMasters();

                        foreach (Master master in masters)
                        {
                            Console.WriteLine("\n" + master.Id + " " + master.Name);
                        }
                        break;
                    }
                case "2":
                    Console.WriteLine("\n\nPodaj nazwę > ");
                    input = Console.ReadLine();
                    InsertSingleMaster(input);
                    Console.WriteLine("\nDodano!");
                    break;
                case "3":
                    Console.WriteLine("\n\nPodaj id, które zmienić > ");
                    input = Console.ReadLine();
                    int arg1 = Int32.Parse(input.Trim());

                    Console.WriteLine("\n\nPodaj nazwę > ");
                    input = Console.ReadLine();
                    string arg2 = input;

                    UpdateSingleMaster(arg1, arg2);
                    Console.WriteLine("\nZmieniono!");
                    break;
                case "4":
                    Console.WriteLine("\n\nPodaj id, które usunąć > ");
                    input = Console.ReadLine();
                    int id_to_del = Int32.Parse(input.Trim());
                    DeleteSingleMaster(id_to_del);
                    Console.WriteLine("\nUsunięto!");
                    break;
                default:
                    Console.WriteLine("Błędna wartość...");
                    break;

            }

        }
    }
}
