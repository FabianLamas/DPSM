using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    public class Category
    {
        public Category()
        {

        }
        public Category(string cat, string sec, string descripcion)
        {
            this.CAT_ID = cat;
            this.DESCRIPTION = descripcion;
            this.SEC_ID = sec;
        }

        public string CAT_ID { get; set; }
        public string SEC_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
