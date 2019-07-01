using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace IpestV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tech1_1 : ContentPage
	{
		public Tech1_1 ()
		{
			InitializeComponent ();
            stopwatch = new Stopwatch();
            this.confirmed.IsVisible = false; 
		}

        Stopwatch stopwatch;
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(30));
            double longitude;
            double latitude;
            longitude = position.Longitude;
            latitude = position.Latitude;
            this.longt.Text = longitude.ToString();
            this.post.Text = latitude.ToString();

            if (longitude != 0 && latitude != 0)
            {
                this.confirmed.IsVisible = true;

                stopwatch.Start();
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    lblStopwatch.Text = stopwatch.Elapsed.ToString();
                    return true; 
                }
                );
                this.btn.IsVisible = false; 
            }
         

        }

        private async void Logout_Clicked(object sender, EventArgs e)
        {
            

            try
            {
                Scann();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("IOException source: {0}", ex.Source);
                throw;
            }


        }

        public async void Scann()
        {

            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) =>
            {
                // Stop scanning
                ScannerPage.IsScanning = false;

                // Alert with scanned code
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    var res = DisplayAlert(" Scan Code ", result.Text, " OK ");
                    await Navigation.PushModalAsync(new NavigationPage(new Tech1()));

                });

            };

            await Navigation.PushAsync(ScannerPage);
        }


    }
}