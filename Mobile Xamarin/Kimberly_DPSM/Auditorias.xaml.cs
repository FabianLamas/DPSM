using System;
using System.Collections.Generic;
using Modelos;

using Xamarin.Forms;

namespace Kimberly_DPSM
{
    public partial class Auditorias : ContentPage
    {
        Customer customer = new Customer();

        public Auditorias()
        {
            InitializeComponent();
            this.BindingContext = new Customer();
            FillCustomer();
        }



        private void ClickedBack(object sender, EventArgs e)
        {

        }
        private void FillCustomer()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { id = "1", Address = "Av Panamericana 1500", Name = "Coto" });
            customers.Add(new Customer { id = "2", Address = "Av 25 de mayo 700", Name = "Disco" });
            customers.Add(new Customer { id = "3", Address = "Av Rogelio Martinez 1500", Name = "Vea" });
            customers.Add(new Customer { id = "4", Address = "Publica 1500", Name = "Super Chino" });
            customers.Add(new Customer { id = "5", Address = "Av Colo 5400", Name = "Coto" });
            customers.Add(new Customer { id = "6", Address = "Av Color 1500", Name = "Carrefour" });
            customers.Add(new Customer { id = "7", Address = "Av La Voz del Interior 168", Name = "Mariano Max" });
            lst_Customers.ItemsSource = customers;

        }
        private void itemTapedCustomer(object sender, ItemTappedEventArgs e)
        {
            Customer customerTaped = e.Item as Customer;

            Navigation.PushAsync(new MenuAuditCustomer());
        }
    }
}
