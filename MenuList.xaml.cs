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
    public partial class MenuList : ContentPage
    {
        public MenuList()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuList());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuList());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyCart());
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbldisp.Text = String.Format("  {0:00}", e.NewValue);
        }

        private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbldisp1.Text = String.Format("  {0:00}", e.NewValue);
        }

        private void stepper2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbldisp2.Text = String.Format("  {0:00}", e.NewValue);
        }

        private void stepper3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbldisp3.Text = String.Format("  {0:00}", e.NewValue);
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListMenu());
        }
    }
}