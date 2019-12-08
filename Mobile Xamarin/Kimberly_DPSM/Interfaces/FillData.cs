using System;
using System.Collections.Generic;
using Kimberly_DPSM.ServicioLocal;
using Modelos;


namespace Kimberly_DPSM.Interfaces
{
    public class FillData
    {
        ServicioCategorias servicio = new ServicioCategorias();

        public FillData()
        {

        }
        List<Category> listado = new List<Category>();

        public void FillCategory()
        {
            listado.Add(new Category("B018", "A001", "Senior Incont"));
            listado.Add(new Category("B045", "A001", "FEM WELLNESS"));
            listado.Add(new Category("B061", "A002", "HFB TOILETRIES & MASK"));
            listado.Add(new Category("B019", "A002", "Table Napkins"));
            listado.Add(new Category("B024", "A002", "Wipers"));
            listado.Add(new Category("B015", "A002", "Non-Tissue"));
            listado.Add(new Category("B016", "A002", "Hard Rolls"));
            listado.Add(new Category("B017", "A002", "Bath Tissue"));
            listado.Add(new Category("B005", "A002", "Towels"));
            listado.Add(new Category("B006", "A002", "Facial Tissue"));
            listado.Add(new Category("B011", "A003", "Diapers"));
            listado.Add(new Category("B002", "A003", "BCC Wipes"));
            listado.Add(new Category("B004", "A003", "Child"));
            listado.Add(new Category("B044", "A003", "Diaper Pants"));
            listado.Add(new Category("B020", "A003", "BATH BODY & ACCESSORIES"));
            listado.Add(new Category("B046", "A003", "Other BCC"));
            listado.Add(new Category("B060", "0005", "PANTS"));
            listado.Add(new Category("B012", "A005", "Liners"));
            listado.Add(new Category("B013", "A005", "Pads"));
            listado.Add(new Category("B014", "A005", "Tampons"));
            listado.Add(new Category("B008", "A005", "Fem Skin Care"));
            listado.Add(new Category("B009", "A005", "Fem Wipes"));


            foreach (var item in listado)
            {
                servicio.insert(item);
            }
        }

    }
}
