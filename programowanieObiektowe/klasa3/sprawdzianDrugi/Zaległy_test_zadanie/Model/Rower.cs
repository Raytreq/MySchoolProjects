using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zaległy_test_zadanie.Model
{
    public class Rower
    {
        public int AktualnyBieg { get; set; }
        public string Producent { get; set; }
        public int LiczbaBiegow { get; set; }
        public Typ Typ { get; set; }
        public decimal Cena { get; set; }
        public string[] Akcesoria { get; set; }
        public Rower(string producent, int liczbaBiegow, Typ typ, decimal cena, string[] akcesoria, int aktualnyBieg = 1)
        {
            AktualnyBieg = aktualnyBieg;
            Producent = producent;
            LiczbaBiegow = liczbaBiegow;
            Typ = typ;
            Cena = cena;
            Akcesoria = akcesoria;
        }


        public static Rower operator+(Rower a, int b)
        {
            if (a.AktualnyBieg < a.LiczbaBiegow) {
                int AktualniejszyBieg = a.AktualnyBieg + b;
                return new Rower(a.Producent, a.LiczbaBiegow, a.Typ, a.Cena, a.Akcesoria, AktualniejszyBieg);
            }
            return new Rower(a.Producent, a.LiczbaBiegow, a.Typ, a.Cena, a.Akcesoria, a.AktualnyBieg);
        }

        public static Rower operator -(Rower a, int b) 
        {
            if (a.AktualnyBieg > 1)
            {
                int AktualniejszyBieg = a.AktualnyBieg - b;
                return new Rower(a.Producent, a.LiczbaBiegow, a.Typ, a.Cena, a.Akcesoria, AktualniejszyBieg);
            }
            return new Rower(a.Producent, a.LiczbaBiegow, a.Typ, a.Cena, a.Akcesoria, a.AktualnyBieg);
        }


        public static Rower operator +(Rower a, string b)
        {
            var tablica = new string[a.Akcesoria.Length + 1];


            for( int i = 0; i < tablica.Length; i++ )
            {
                tablica[i] = a.Akcesoria[i];
            }

            int x = tablica.Length;
            x--;
            tablica[x] = b;

            return new Rower(a.Producent, a.LiczbaBiegow, a.Typ, a.Cena, tablica, a.AktualnyBieg);
        }
        
        
        public static bool operator>(Rower a , decimal b) {
            if(a.Cena > b)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Rower a, decimal b)
        {
            if (a.Cena < b)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Rower a, decimal b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Rower a, decimal b)
        {
            return !a.Equals(b);
        }

        public override bool Equals(object? obj)
        {
            var x = this;
            var y = obj as Rower;

            if (x != null && y != null) {
                if(x.LiczbaBiegow == y.LiczbaBiegow)
                {
                    if (x.Producent == y.Producent)
                    { 
                        if(x.Typ == y.Typ)
                        {
                            return true;
                        }

                        return false;
                    }

                    return false;
                }

                return false;
            }

            return false;
        }


        public static implicit operator string(Rower a)
        {
            return a.ToString();
        }

        public override string ToString()
        {
            var x = this;
            string ciag = ($"{x.AktualnyBieg} {x.LiczbaBiegow} {x.Cena} {x.Typ} {x.Producent} {x.Akcesoria}");
            return ciag;
        }


        public static explicit operator int(Rower a)
        {
            int rezultat = a.AktualnyBieg;
            return rezultat;
        }

        public void Display()
        {
            var item = this as Rower;

            Console.WriteLine(item.AktualnyBieg);
            Console.WriteLine(item.LiczbaBiegow);
            Console.WriteLine(item.Cena);
            Console.WriteLine(item.Typ);
            Console.WriteLine(item.Producent);
            for (int i = 0; i < item.Akcesoria.Length; i++)
            {
                Console.WriteLine(item.Akcesoria[i]);
            }
        }
    }
}
    

