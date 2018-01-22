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
	public partial class MyOrders : ContentPage
	{
		public MyOrders ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyOrdersDetail());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckOut());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyOrdersDetail());
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckOut());
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyOrdersDetail());
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckOut());
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyOrdersDetail());
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckOut());
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckOut());
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyOrdersDetail());
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListMenu());
        }

    }
}