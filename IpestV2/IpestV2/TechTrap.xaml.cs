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
	public partial class TechTrap : ContentPage
	{
		public TechTrap ()
		{
			InitializeComponent ();
		}

        private async void Issue_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage( new TechIssue())); 
        }

        private async void Maintain_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new TechMaintain()));
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}