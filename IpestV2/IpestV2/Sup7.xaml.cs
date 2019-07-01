using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;

namespace IpestV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sup7 : ContentPage
	{
		public Sup7 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var entries = new[] {
                new Entry(2)
                {
                    Label = "Tom",
                    ValueLabel = "2 / 5",
                    Color = SKColor.Parse("#266489"),
                    
                },

                new Entry(2)
                {
                Label = "George",
                ValueLabel = "2 / 2",
                Color = SKColor.Parse("#266489"),

                },
                 new Entry(3)
                {
                Label = "Victor",
                ValueLabel = "3 / 7",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(1)
                {
                Label = "Rose",
                ValueLabel = "1 / 2",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(1)
                {
                Label = "Robert",
                ValueLabel = "1 / 1",
                Color = SKColor.Parse("#266489")
                 },

                new Entry(6)
                {
                Label = "Gerry",
                ValueLabel = "6 / 6",
                Color = SKColor.Parse("#266489")
                 },


};
              // var chart2 = new BarChart() { Entries = entries };
               var chart = new LineChart() { Entries = entries  };
            //var chart2 = new LineChart() { Entries = entries };

            // var chart = new RadialGaugeChart() { Entries = entries };
         //   this.chartView2.Chart = chart2;
            this.chartView2.Chart = chart;
            
        }

        private void Traps_Clicked(object sender, EventArgs e)
        {

        }

        private void Sites_Clicked(object sender, EventArgs e)
        {

        }
    }
}