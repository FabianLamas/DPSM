using System;
using System.Collections.Generic;
using Modelos;
using Xamarin.Forms;

namespace Kimberly_DPSM
{
    public partial class SecondPageCustomerAudit : ContentPage
    {
        public SecondPageCustomerAudit()
        {
            InitializeComponent();
        }


        public SecondPageCustomerAudit(string id)
        {
            InitializeComponent();

            this.BindingContext = new Category();

            CargarCategorias(id);

        }

        List<Category> categories = new List<Category>();
        ServicioLocal.Infraestructura infraestructura = new ServicioLocal.Infraestructura();

        public void CargarCategorias(string id)
        {
            lstCategorias.ItemsSource = infraestructura.GetAllCategories(id);
        }
        private void itemTapped_event(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
