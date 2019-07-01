using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace IpestV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tech7 : ContentPage
	{
		public Tech7 ()
		{
			InitializeComponent ();
		}

 

        private void Migrate_Clicked(object sender, EventArgs e)
        {
            Scanner(); 
        }
        public async void Scanner()
            {
                var ScannerPage = new ZXingScannerPage();

                ScannerPage.OnScanResult += (result) => {
                    // Stop scanning
                    ScannerPage.IsScanning = false;

                    // Alert with scanned code
                    Device.BeginInvokeOnMainThread(() => {
                        Navigation.PopAsync();
                        DisplayAlert(" Scan Code ", result.Text, " OK ");
                        Navigation.PushModalAsync(new NavigationPage(new TechIntegrate()));
                    });
                };


                await Navigation.PushAsync(ScannerPage);



            }

        }
    
}