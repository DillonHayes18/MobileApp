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
	public partial class Smg : ContentPage
	{
        public Smg()
        {
            InitializeComponent();
        }

        async void MP5_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void MP7_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void AUG_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void P90_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void UZI_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void BIZON_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }
    }
}