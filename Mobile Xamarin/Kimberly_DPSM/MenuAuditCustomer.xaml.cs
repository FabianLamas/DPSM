using System;
using System.Collections.Generic;
using Modelos;
using Xamarin.Forms;

namespace Kimberly_DPSM
{
    public partial class MenuAuditCustomer : ContentPage
    {
        public MenuAuditCustomer()
        {
            InitializeComponent();
            this.BindingContext = new Sector();
            FillData();
        }
        List<Sector> sectors = new List<Sector>();

        ServicioLocal.ServicioLocalSector ServicioLocal = new ServicioLocal.ServicioLocalSector();

        private void FillData()
        {
            sectors = ServicioLocal.FillSectores();
            lstSectors.ItemsSource = sectors;
        }

        private void itemTapped_event(object sender, ItemTappedEventArgs e)
        {
            Sector sector = e.Item as Sector;

            Navigation.PushAsync(new SecondPageCustomerAudit(sector.SEC_ID));
        }

    }
}
