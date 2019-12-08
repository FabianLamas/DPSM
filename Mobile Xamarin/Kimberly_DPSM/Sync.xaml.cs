using System;
using System.Collections.Generic;
using Kimberly_DPSM.Interfaces;
using Xamarin.Forms;

namespace Kimberly_DPSM
{
    public partial class Sync : ContentPage
    {
        public Sync()
        {
            InitializeComponent();
        }

        private void DescPosicionesClick(object sender, EventArgs e)
        {

        }
        private void DescAuditoriasClick(object sender, EventArgs e)
        {

        }
        private void subirAuditoriasClick(object sender, EventArgs e)
        {

        }
        private void DescargarCategoriasClick(object sender, EventArgs e)
        {
            FillData servicio = new FillData();
            servicio.FillCategory();

        }
    }
}
