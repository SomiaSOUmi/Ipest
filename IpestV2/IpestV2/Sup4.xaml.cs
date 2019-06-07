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
	public partial class Sup4 : ContentPage
	{
		public Sup4 ()
		{
			InitializeComponent ();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sup5());
        }
    }
}