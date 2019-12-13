using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HayesDillonApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Assault : ContentPage
	{
        public Assault()
        {
            InitializeComponent();
        }

        async void M13_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }
        async void M4A1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 28" + "\nFire rate: 800" + "\nDPS: 392", "OK");
        }

        async void FR556_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 40" + "\nFire rate: 1250" + "\nDPS: 360", "OK");
        }

        async void AK47_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 42" + "\nFire rate: 560" + "\nDPS: 420", "OK");
        }

        async void FAL_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 54" + "\nFire rate: 470" + "\nDPS: 432", "OK");
        }

        async void SCAR_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 35" + "\nFire rate: 580" + "\nDPS: 350", "OK");
        }

        async void ODEN_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 62" + "\nFire rate: 410" + "\nDPS: 434", "OK");
        }

        async void KILO_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 28" + "\nFire rate: 750" + "\nDPS: 364", "OK");
        }

        async void RAM_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 400" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }
    }
}