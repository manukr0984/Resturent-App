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
    public partial class PushNotifications : ContentPage
    {
        public PushNotifications()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListMenu());
        }
    }
}