using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace krozmus_grid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OneClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 1;
        }

        private void TwoClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 2;
        }

        private void ThreeClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 3;
        }

        private void FourClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 4;
        }

        private void FiveClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 5;
        }

        private void SixClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 6;
        }

        private void SevenClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 7;
        }

        private void EightClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 8;
        }

        private void NineClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 9;
        }

        private void ZeroClicked(object sender, EventArgs e)
        {
            PhoneNumber.Text = PhoneNumber.Text + 0;
        }

        private void DialClicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(PhoneNumber.Text);
            }
            catch (ArgumentNullException anEx)
            {
                PhoneNumber.Text = anEx.Message;
            }
            catch (FeatureNotSupportedException ex)
            {
                PhoneNumber.Text = ex.Message;
            }
            catch (Exception ex)
            {
                PhoneNumber.Text = ex.Message;
            }
        }

    }
}
