using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinSqlite.CustomControls;
using XamarinSqlite.iOS.CustomRenderers;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace XamarinSqlite.iOS.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIKit.UIColor.Black;
                Control.TextColor = UIKit.UIColor.Blue;
            }
        }
    }
}