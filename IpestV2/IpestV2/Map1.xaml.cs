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
    public partial class Map1 : TabbedPage
    {
        public Map1 ()
        {
            
            this.Children.Add(new MapPage { Title = "Map/Zoom", Icon = "glyphish_74_location.png" });

            // demonstrates the map control with zooming and map-types
            this.Children.Add(new PinPage { Title = "Pins", Icon = "glyphish_07_map_marker.png" });

            // demonstrates the Geocoder class
            this.Children.Add(new GeocoderPage { Title = "Geocode", Icon = "glyphish_13_target.png" });

            // opens the platform's native Map app
            this.Children.Add(new MapAppPage { Title = "Map App", Icon = "glyphish_103_map.png" });
            InitializeComponent();
        }
    }
}