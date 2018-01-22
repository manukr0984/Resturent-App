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
	public partial class PaymentMethods : ContentPage
	{
		public PaymentMethods ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Delete Payment Method", "Are you sure to delete this Payment Method ?", "Continue", "Cancel");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewPaymentMethod());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListMenu());
        }
    }
}