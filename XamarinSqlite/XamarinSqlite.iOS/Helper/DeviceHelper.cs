using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinSqlite.Helper;
using XamarinSqlite.iOS.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace XamarinSqlite.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "IOS ortamı çalıştırıldı.";
        }
    }
}