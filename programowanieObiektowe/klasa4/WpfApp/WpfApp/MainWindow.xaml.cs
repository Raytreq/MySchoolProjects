using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Model;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uczelnia test = new Uczelnia();
        public MainWindow()
        {
            if(File.Exists("file.json"))
            {
                test = JsonConvert.DeserializeObject<Uczelnia>(File.ReadAllText("file.json"));
            }
            else
            {
                test = new Uczelnia();
            }

            InitializeComponent();
            this.DataContext = test;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(test);
            File.WriteAllText("file.json", json);
        }
    }
}
