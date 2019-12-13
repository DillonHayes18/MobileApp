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
	public partial class Sniper : ContentPage
	{
        public Sniper()
        {
            InitializeComponent();
        }

        async void AX_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void DRAG_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }

        async void HDR_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stats", "Damage: 24" + "\nFire rate: 900" + "\nDPS: 384", "OK");
        }
    }
}