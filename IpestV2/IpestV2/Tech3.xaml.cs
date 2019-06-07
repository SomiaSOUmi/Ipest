using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Timers;

namespace IpestV2
        {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tech3 : ContentPage
    {    
        public Tech3 ()
		{
			InitializeComponent ();       
        }

        public ElapsedEventHandler Timer_Elapsed { get; private set; }

        private void Cview_BindingContextChanged(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1;   
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            var timePicker = new TimePicker()
            {
                Time = DateTime.Now.TimeOfDay,
                TextColor = Color.FromHex("#ffffff"),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            this.TimerValue.Text = Convert.ToString(timePicker); 
        }


        private async void Qrout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Tech2()));
        }

    }
}