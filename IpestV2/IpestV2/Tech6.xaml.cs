using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IpestV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tech6 : ContentPage
	{
		public Tech6 ()
		{
			InitializeComponent ();
            this.imgShow.Source = ImageSource.FromResource("IpestV2.images.pic4.png");
            this.Icon1.Source = ImageSource.FromResource("IpestV2.images.icon1.png");
            this.Icon2.Source = ImageSource.FromResource("IpestV2.images.icon2.png");
            this.Icon3.Source = ImageSource.FromResource("IpestV2.images.icon3.png");
            this.Icon4.Source = ImageSource.FromResource("IpestV2.images.icon4.png");


        }
    }
}