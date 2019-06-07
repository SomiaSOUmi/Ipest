using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps; 

namespace IpestV2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tech4 : ContentPage
    {
        public Tech4()
        {
            // table of integers used to simulate database for full action report in dashboard window
           // int[,] table = new int[,] { { 1, 2, 3, 4 } , { 4, 5, 6, 7 } , {8,9,5,6 } }; 
            InitializeComponent();
            this.imgShow.Source = ImageSource.FromResource("IpestV2.images.pic4.png");
        

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Map1());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

        }

  
    }



    }
    