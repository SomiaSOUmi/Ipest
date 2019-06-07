using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IpestV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sup1 : ContentPage
	{
		public Sup1 ()
		{
			InitializeComponent ();
            this.imgShow.Source = ImageSource.FromResource("IpestV2.images.pic4.png");

        }

        private async void Dash_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup2());
        }

        private async void Care_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup4());
        }

        private async void Perform_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup6());
        }

        private async void Track_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup6());
        }

        private async void Integrate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup8());
        }
    }
}