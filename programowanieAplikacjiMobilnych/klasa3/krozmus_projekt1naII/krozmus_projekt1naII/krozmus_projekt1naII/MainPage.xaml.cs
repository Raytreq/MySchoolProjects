using krozmus_projekt1naII.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace krozmus_projekt1naII
{
    public partial class MainPage : ContentPage
    {

        List<Search> Searches;


        public MainPage()
        {
            InitializeComponent();

            Searches = new List<Search>
            {
                new Search(1,"West Hollywood, CA, United States",new DateTime(2016, 9, 1), new DateTime(2016, 11, 1)),
                new Search(2,"Las Vegas, Nevada, United States",new DateTime(2016, 9, 3), new DateTime(2016, 12, 4)),
                new Search(3,"Żywiec, Śląskie, Poland",new DateTime(2015, 6, 23), new DateTime(2015, 6, 30)),
                new Search(4,"Kraków, Małopolskie, Poland",new DateTime(2021, 2, 15), new DateTime(2022, 5, 4)),
                new Search(5,"Groningen, Groningen, Netherlands",new DateTime(2022, 3, 7), new DateTime(2022, 3, 18)),
                new Search(6,"Middletown, Connecticut, United States",new DateTime(2000, 1, 1), new DateTime(2009, 12, 31)),
                new Search(7,"Olsztyn, Mazurskie, Poland",new DateTime(2018, 7, 15), new DateTime(2019, 8, 1)),
                new Search(8,"Kyoto, Honsiu, Japan",new DateTime(2008, 2, 3), new DateTime(2010, 8, 9))
            };
            Lista.ItemsSource = Searches;
        }


        private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;

            DisplayAlert("Location", search.Location, "ok");
        }


        private void Delete_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var search = menuItem.CommandParameter as Search;

            Searches.Remove(search);
        }


        private void Lista_Refreshing(object sender, EventArgs e)
        {
            Lista.ItemsSource = null;
            Lista.ItemsSource = Searches;

            Lista.EndRefresh();
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Lista.ItemsSource = Searches.Where(s => s.Location.StartsWith(e.NewTextValue)).ToList();
        }
    }
}
