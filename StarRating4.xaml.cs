﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StarRating4 : ContentPage
	{
		public StarRating4 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarRating1());
        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarRating2());
        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarRating3());
        }

        private void TapGestureRecognizer_Tapped5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarRating());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListMenu());
        }
    }
}