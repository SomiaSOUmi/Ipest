using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms; 
using Xamarin.Forms.Maps;
using System.Windows;
using Xamarin.Forms.Platform.Android;
using Android.Webkit;
using Plugin.CurrentActivity;

namespace IpestV2.Droid
{
    [Activity(Label = "IpestV2", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity //FormsAppCompatActivity
    {
         protected override void OnCreate(Bundle savedInstanceState)
        {

          

            CrossCurrentActivity.Current.Init(this, savedInstanceState);

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            global::Xamarin.FormsMaps.Init(this, savedInstanceState);
            Plugin.InputKit.Platforms.Droid.Config.Init(this, savedInstanceState); // < ---- Add here

            LoadApplication(new App());
        
         }
    

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            //Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions , grantResults);

            // ZXing.Net.Mobile.Forms
            // Xamarin.Forms.Maps
            // Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            //  base.OnRequestPermissionsResult(requestCode, permissions, grantResults); 
        }






    }
}