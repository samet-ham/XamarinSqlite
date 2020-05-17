using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqlite.Data;
using XamarinSqlite.Views;

namespace XamarinSqlite
{
    public partial class App : Application
    {
        static UserDatabase database;

        public static UserDatabase Database
        {
            get 
            {
                if (database == null)
                {
                    database = new UserDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HostKod.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();



            MainPage = new NavigationPage(new UsersPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
