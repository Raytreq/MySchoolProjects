using System;


class krozmus_2
{

    static void LiczStatystykiParzystych(int[] t, out int suma, out long iloczyn, out double srednia)
    {
        suma = 0;
        iloczyn = 1;
        srednia = 0;
        int iloczParzystych = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] % 2 == 0)
            {
                suma = suma + t[i];
                iloczParzystych++;
            }
            else
            {
                continue;
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] % 2 == 0)
            {
                iloczyn = iloczyn * t[i];
            }
            else
            {
                continue;
            }
        }

        if (iloczParzystych > 0)
        {
            srednia = suma / iloczParzystych;
        }
        if (suma == 0)
        {
            iloczyn = 0;
        }
    }


    static void Main()
    {
        Random rnd = new Random();
        int suma = 0;
        long iloczyn = 1;
        double srednia = 0;
        int min = 0;
        int max = 0;
        int rozmiarTab = 0;

        Console.Write("\nPodaj rozmiar tablicy: ");
        int.TryParse(Console.ReadLine(), out rozmiarTab);
        int[] tablica = new int[rozmiarTab];
        Console.Write("\nPodaj minimalną wartość: ");
        int.TryParse(Console.ReadLine(), out min);
        Console.Write("\nPodaj maksymalną wartość ");
        int.TryParse(Console.ReadLine(), out max);

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = rnd.Next(min, max);
        }

        LiczStatystykiParzystych(tablica, out suma, out iloczyn, out srednia);
        Console.WriteLine("\n\nSuma liczb parzystych: {0}\nIloczyn liczb parzystych: {1}\nŚrednia liczb parzystych: {2}", suma, iloczyn, srednia);
    }

}