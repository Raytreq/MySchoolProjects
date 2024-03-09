using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pitagoras_krozmus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void przyciskOblPressed(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, h = 0;

            double.TryParse(entA.Text, out a);
            double.TryParse(entB.Text, out b);
            double.TryParse(entC.Text, out c);
            double.TryParse(entH.Text, out h);

            if( ((a*a)+(b*b)) == (c*c) )
            {
                Wynik.Text = "Podany trójkąt jest prostokątny; Wzór Pitagorosa może zostać na nim poprawnie użyty.";

            }
            else
            {
                Wynik.Text = "Podany trójkąt nie jest prostokątny; Wzór Pitagorasa nie może zostać na nim użyty prawidłowo.";
            }

            double obwod = a + b + c;
            double pole = (a * h) / 2;

            Obwod.Text = "Obwód wynosi: " + Convert.ToString(obwod);
            Pole.Text = "Pole wynosi: " + Convert.ToString(pole);
        }
    }
}
