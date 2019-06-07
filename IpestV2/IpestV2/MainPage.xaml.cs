using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySql.Data.MySqlClient;

namespace IpestV2
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {

            InitializeComponent();
           
            this.imgShow.Source = ImageSource.FromResource("IpestV2.images.pic.png");

        }



        private async void Button_Clicked_1(object sender, EventArgs e)
        {
    
                await Navigation.PushModalAsync(new NavigationPage(new Sup1()));

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Sup1()));

        }
    }
}
