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
	public partial class Shotgun : ContentPage
	{
        public Shotgun()
        {
            InitializeComponent();
        }

        async void MODEL_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void S25_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void R9_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void ORIGIN_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }
    }
}