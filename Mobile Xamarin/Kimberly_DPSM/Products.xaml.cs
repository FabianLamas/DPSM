using System;
using System.Collections.Generic;
using Modelos;
using Xamarin.Forms;

namespace Kimberly_DPSM
{
    public partial class Products : ContentPage
    {
        public Products()
        {
            InitializeComponent();
            this.BindingContext = new Product();
            FillData();
        }

        private void FillData()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Huggies", Sku = "111212313913", Price = "54,44", Status = 1 });
            products.Add(new Product { Name = "Huggies Sec", Sku = "111212313913", Price = "60,44", Status = 1 });
            products.Add(new Product { Name = "Huggies Green", Sku = "111212313913", Price = "34,64", Status = 1 });
            products.Add(new Product { Name = "Scott small", Sku = "111212313913", Price = "14,49", Status = 1 });
            products.Add(new Product { Name = "Scott Big", Sku = "111212313913", Price = "44,58", Status = 1 });
            products.Add(new Product { Name = "Toallitas Humedas", Sku = "111212313913", Price = "94,15", Status = 1 });
            products.Add(new Product { Name = "Protectores Femeninos", Sku = "111212313913", Price = "54,44", Status = 1 });

            ProductsList.ItemsSource = products;
        }
        private void itemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ProductView());
        }
    }


}
