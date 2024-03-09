using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
        }

        string[] quotes =
        {
            "Life is never fair, and perhaps it is a good thing for most of us that it is not.",
            "The only impossible journey is the one you never begin.",
            "Only a life lived for others is a life worthwhile.",
            "You only live once, but if you do it right, once is enough.",
            "Life is ours to be spent, not to be saved.",
            "Love the life you live. Live the life you love.",
            "Life is trying things to see if they work.",
            "The secret of success is to do the common thing uncommonly well.",
            "The way to get started is to quit talking and begin doing.",
            "It is better to fail in originality than to succeed in imitation.",
            "Success is walking from failure to failure with no loss of enthusiasm."
        };

        private void Button_Pressed(object sender, EventArgs e)
        {

            Random rnd = new Random();
            quote.Text = quotes[rnd.Next(quotes.Length)];

        }
    }
}