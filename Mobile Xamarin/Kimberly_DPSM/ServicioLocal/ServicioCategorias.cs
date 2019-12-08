using System;
using Modelos;

namespace Kimberly_DPSM.ServicioLocal
{
    public class ServicioCategorias
    {
        public ServicioCategorias()
        {

        }

        Infraestructura infraestructura = new Infraestructura();

        public bool insert(Category categoria)
        {
            int i = infraestructura.connection.Insert(categoria);
            if (i > 1)
                return true;

            return false;

        }
    }
}
