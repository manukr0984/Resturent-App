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
	public partial class AdminLogin : ContentPage
	{
		public AdminLogin ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WelcomeAdmin());
        }
    }
}