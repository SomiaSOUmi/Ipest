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
	public partial class Sup5 : ContentPage
	{
		public Sup5 ()
		{
			InitializeComponent ();
		}

        private void Traps_Clicked(object sender, EventArgs e)
        {
            var entries = new[] {
                new Entry(200)
                {
                    Label = "January",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new Entry(400)
                {
                Label = "February",
                ValueLabel = "400",
                Color = SKColor.Parse("#266489")
                },
                new Entry(100)
                {
                Label = "March",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(200)
                {
                Label = "April",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                 new Entry(300)
                {
                Label = "May",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(100)
                {
                Label = "June",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(100)
                {
                Label = "July",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(100)
                {
                Label = "August",
                ValueLabel = "150",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "September",
                ValueLabel = "200",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "October",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "November",
                ValueLabel = "400",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "December",
                ValueLabel = "300",
                Color = SKColor.Parse("#266489")
                 }

};
            var chart = new BarChart() { Entries = entries };
          //  var chart = new LineChart() { Entries = entries };
            this.chartView.Chart = chart;

        }

        private void Sites_Clicked(object sender, EventArgs e)
        {
            var entries = new[] {
                new Entry(200)
                {
                    Label = "January",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new Entry(400)
                {
                Label = "February",
                ValueLabel = "400",
                Color = SKColor.Parse("#266489")
                },
                new Entry(100)
                {
                Label = "March",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(200)
                {
                Label = "April",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                 new Entry(300)
                {
                Label = "May",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(100)
                {
                Label = "June",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(100)
                {
                Label = "July",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(100)
                {
                Label = "August",
                ValueLabel = "150",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "September",
                ValueLabel = "200",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "October",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "November",
                ValueLabel = "400",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "December",
                ValueLabel = "300",
                Color = SKColor.Parse("#266489")
                 }

};
           // var chart = new BarChart() { Entries = entries };
            var chart = new LineChart() { Entries = entries };
            this.chartView.Chart = chart;
        }

        private void Scheduled_Clicked(object sender, EventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var entries = new[] {
                new Entry(200)
                {
                    Label = "January",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new Entry(400)
                {
                Label = "February",
                ValueLabel = "400",
                Color = SKColor.Parse("#266489")
                },
                new Entry(100)
                {
                Label = "March",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),
                
                },
                new Entry(200)
                {
                Label = "April",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                 new Entry(300)
                {
                Label = "May",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(100)
                {
                Label = "June",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(100)
                {
                Label = "July",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(100)
                {
                Label = "August",
                ValueLabel = "150",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "September",
                ValueLabel = "200",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "October",
                ValueLabel = "100",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "November",
                ValueLabel = "400",
                Color = SKColor.Parse("#266489")
                 },
                new Entry(100)
                {
                Label = "December",
                ValueLabel = "300",
                Color = SKColor.Parse("#266489")
                 }

};
            var chart = new BarChart() { Entries = entries };
         //   var chart2 = new LineChart() { Entries = entries  };
           // var chart = new RadialGaugeChart() { Entries = entries };

            this.chartView.Chart = chart;
        }

    }
}