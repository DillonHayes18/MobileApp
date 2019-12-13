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
	public partial class Pistol : ContentPage
	{
		public Pistol ()
		{
			InitializeComponent ();
		}

        async void X16_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void P1911_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void P357_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" +"\nFire Rate: 900" +"\nDPS: 384", "OK");
        }

        async void DEAGLE_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire Rate: 900" + "\nDPS: 384", "OK");
        }

        async void M19_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire Rate: 900" + "\nDPS: 384", "OK");
        }
    }
}