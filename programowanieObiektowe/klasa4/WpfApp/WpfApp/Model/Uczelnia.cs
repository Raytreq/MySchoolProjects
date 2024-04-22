using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    class Uczelnia
    {
        public String Nazwa { get; set; }
        public String Miejscowosc { get; set; }
        public String Specjalizacja { get; set; }
        public bool Uniwersytet {  get; set; }

        public Uczelnia() { Nazwa = "ATH"; Miejscowosc = "Bielsko-Biała"; Specjalizacja = "Informatyka"; Uniwersytet = true; }
    }
}
