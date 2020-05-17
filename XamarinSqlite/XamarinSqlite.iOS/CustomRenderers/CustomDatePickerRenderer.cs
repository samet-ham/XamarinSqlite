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

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace XamarinSqlite.iOS.CustomRenderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            CustomDatePicker picker = (CustomDatePicker)Element;

            if (picker != null)
            {
                Control.TextColor = picker.TextColor.ToUIColor();
            }
        }
    }
}