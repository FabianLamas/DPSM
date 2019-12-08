using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    public class Sector
    {
        public string SEC_ID { get; set; }
        public string DESCRIPTION { get; set; }

        public Sector()
        {

        }
        public Sector(string id, string description)
        {
            this.SEC_ID = id;
            this.DESCRIPTION = description;
        }
    }
}
