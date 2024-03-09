using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace projektimage
{
    public partial class MainPage : ContentPage
    {
        public int imgID { get; set; }


        public MainPage()
        {
            InitializeComponent();
            imgID = 1;

            Image.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://loremflickr.com/1920/1080?random=1")
            };

        }


        private void Previous(object sender, EventArgs e)
        {
            imgID--;
            if (imgID <= 2)
            {
                imgID = 10;
            }

            Image.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://loremflickr.com/1920/1080?random=" + imgID.ToString())
            };
        }


        private void Next(object sender, EventArgs e)
        {
            imgID++;
            if (imgID >= 11)
            {
                imgID = 1;
            }

            Image.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://loremflickr.com/1920/1080?random=" + imgID.ToString())
            };
        }
    }
}
