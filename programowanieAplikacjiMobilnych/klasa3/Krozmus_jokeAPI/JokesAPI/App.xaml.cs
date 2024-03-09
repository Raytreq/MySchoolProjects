using JokesAPI.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JokesAPI
{
    public partial class App : Application
    {
        public static IService RestApiService { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            RestApiService = new Service();
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
