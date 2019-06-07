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

            

            /*         MySqlConnection conn = new MySqlConnection("server=vm1297.tmdcloud.com; port=3306; database=etraprussell_IpestDB; userid= etraprussell; password=Russelletrap; charset=utf8");
                 try
                 {
                     conn.Open();
                 }
                 catch(Exception e) {
                     Console.WriteLine(e.Message.ToString()); 
                 }
                 MySqlCommand cmd = conn.CreateCommand();
                 cmd.CommandText = "SELECT email from User WHERE idUser = 1707143";
                 MySqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     email = reader.ToString();
                 }*/
        }



        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            /// await Navigation.PushModalAsync(new Tech1());
            //  await Navigation.PushModalAsync(new NavigationPage(new Tech1()));
            string email = this.email.ToString();
            if (email == "Technician")
            {
                await Navigation.PushModalAsync(new NavigationPage(new Sup1()));
            }
            else if (email == "Supervisor")
            {
                await Navigation.PushModalAsync(new NavigationPage(new Sup1()));
            }
        }


    

    }
}
