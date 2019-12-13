using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HayesDillonApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Smg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Smg());
        }

        private void Shotgun_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Shotgun());
        }

        private void Sniper_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sniper());
        }

        private void Assault_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Assault());
        }

        private void Secondary_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pistol());
        }
    }
}
