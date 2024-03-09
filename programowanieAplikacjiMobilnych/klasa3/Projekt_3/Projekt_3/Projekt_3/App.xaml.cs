using Projekt_3;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuotesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
