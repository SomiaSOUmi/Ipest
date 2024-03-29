﻿using System;
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
	public partial class Sup8 : ContentPage
	{
		public Sup8 ()
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
                    ValueLabel = "2",
                    Color = SKColor.Parse("#266489")
                },
                new Entry(4)
                {
                Label = "Susan",
                ValueLabel = "4",
                Color = SKColor.Parse("#266489")
                },
                new Entry(1)
                {
                Label = "Bertha",
                ValueLabel = "1",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(2)
                {
                Label = "George",
                ValueLabel = "2",
                Color = SKColor.Parse("#266489"),

                },
                 new Entry(3)
                {
                Label = "Victor",
                ValueLabel = "3",
                Color = SKColor.Parse("#266489")
                 },
                 new Entry(1)
                {
                Label = "Rose",
                ValueLabel = "1",
                Color = SKColor.Parse("#266489"),

                },
                new Entry(1)
                {
                Label = "Robert",
                ValueLabel = "1",
                Color = SKColor.Parse("#266489")
                 },

                new Entry(6)
                {
                Label = "Gerry",
                ValueLabel = "6",
                Color = SKColor.Parse("#266489")
                 },

                new Entry(7)
                {
                Label = "Mary",
                ValueLabel = "7",
                Color = SKColor.Parse("#266489")
                 }

};

            var entries2 = new[] {
                new Entry(2)
                {
                    Label = "Tom",
                    ValueLabel = "2",
                    Color = SKColor.Parse("#266489")
                },
                new Entry(4)
                {
                Label = "Susan",
                ValueLabel = "4",
                Color = SKColor.Parse("#f0c500")
                },
                new Entry(1)
                {
                Label = "Bertha",
                ValueLabel = "1",
                Color = SKColor.Parse("#126450"),

                },
                new Entry(2)
                {
                Label = "George",
                ValueLabel = "2",
                Color = SKColor.Parse("#f0c5b9"),

                },

            }; 
            // var chart = new BarChart() { Entries = entries };
            var chart = new LineChart() { Entries = entries };
            var chart2 = new DonutChart() { Entries = entries2 };

            this.chartView1.Chart = chart;
            this.chartView.Chart = chart2;
        }


    }
}