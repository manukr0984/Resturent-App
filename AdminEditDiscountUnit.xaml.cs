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
    public partial class AdminEditDiscountUnit : ContentPage
    {
        public AdminEditDiscountUnit()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminEditDiscount());
        }      

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Delete Discount Offer", "Are you sure to delete this discount offer ?", "Continue", "Cancel");
        }
    }
}