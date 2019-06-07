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
	public partial class Sup2 : ContentPage
	{
		public Sup2 ()
		{
			InitializeComponent ();
            this.imgShow.Source = ImageSource.FromResource("IpestV2.images.pic4.png");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup2_1());
        }
    }
}