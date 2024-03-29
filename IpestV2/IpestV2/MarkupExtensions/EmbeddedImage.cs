﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms; 
using Xamarin.Forms.Xaml;

namespace IpestV2.MarkupExtensions
{
    public class EmbeddedImage : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            return ImageSource.FromResource(Source); 
        }
    }
}
