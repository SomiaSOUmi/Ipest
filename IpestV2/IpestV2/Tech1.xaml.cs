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
	public partial class Tech1 : ContentPage
	{
        public int min;

        public ElapsedEventHandler Timer_Elapsed { get; private set; }

        public Tech1 ()
		{
			InitializeComponent ();
            this.imgShow.Source = ImageSource.FromResource("IpestV2.images.pic4.png");
        }


        private async void Log_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage (new Tech2()));
        }

        private async void Board_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Tech5());
        }

        private void Scan_Clicked(object sender, EventArgs e)
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
            //await Navigation.PushModalAsync(new NavigationPage(new Tech2()));
        }
        public async void Scann()
        {

            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) =>
            {
                // Stop scanning
                ScannerPage.IsScanning = false;

                // Alert with scanned code
                Device.BeginInvokeOnMainThread( () =>
                {
                   Navigation.PopAsync();
                   var res = DisplayAlert(" Scan Code ", result.Text, " OK ");
                   Navigation.PushModalAsync(new NavigationPage(new TechTrap()));
                                        
                });
                               
            };
            
            await Navigation.PushAsync(ScannerPage);
        }

        private void Set_Clicked(object sender, EventArgs e)
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
                    Navigation.PushModalAsync(new NavigationPage(new Tech7()));
                });
            };


            await Navigation.PushAsync(ScannerPage);



        }


        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }
    }
    }