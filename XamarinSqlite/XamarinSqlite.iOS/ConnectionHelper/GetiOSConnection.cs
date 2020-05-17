using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using UIKit;
using XamarinSqlite.Helper;
using XamarinSqlite.iOS.ConnectionHelper;

[assembly: Xamarin.Forms.Dependency(typeof(GetiOSConnection))]
namespace XamarinSqlite.iOS.ConnectionHelper
{
    public class GetiOSConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}