using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqlite.Models;

namespace XamarinSqlite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserEntryPage : ContentPage
    {
        public UserEntryPage()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            await App.Database.SaveAsync(user);
            await Navigation.PopAsync();
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            await App.Database.DeleteAsync(user);
            await Navigation.PopAsync();
        }
    }
}