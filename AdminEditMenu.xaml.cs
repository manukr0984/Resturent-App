using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminEditMenu : ContentPage
    {
        public AdminEditMenu()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminEditMenuItem());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Delete Saved Address", "Are you sure to delete this Menu Item ?", "Continue", "Cancel");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminAddNewMenuItem());
        }
    }
}