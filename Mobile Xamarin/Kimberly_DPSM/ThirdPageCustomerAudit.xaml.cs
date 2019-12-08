using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Kimberly_DPSM
{
    public partial class ThirdPageCustomerAudit : ContentPage
    {
        public ThirdPageCustomerAudit()
        {
            InitializeComponent();

        }
        private void dpClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Products());
        }
    }
}
