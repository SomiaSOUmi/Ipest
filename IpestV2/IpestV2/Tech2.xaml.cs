using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;


namespace IpestV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tech2 : ContentPage
	{
        public int min ;

        public ElapsedEventHandler Timer_Elapsed { get; private set; }

        public Tech2 ()
		{
			InitializeComponent ();
         
        }

        private  void Qrin_Clicked(object sender, EventArgs e)
        {

            Scanner();
            // await Navigation.PushModalAsync(new NavigationPage(new Tech3()));

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
                    Navigation.PushModalAsync(new NavigationPage(new Tech1_1()));
                });
            };


            await Navigation.PushAsync(ScannerPage);


         
        }
    

        private async void Back2_Clicked(object sender, EventArgs e)
        {

            //await Navigation.PopAsync();
            await Navigation.PushModalAsync(new NavigationPage(new Tech1()));



        }
    }
}

