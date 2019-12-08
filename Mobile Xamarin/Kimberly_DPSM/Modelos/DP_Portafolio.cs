using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    class DP_Portafolio
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string EAN { get; set; }
        public int POS_ID { get; set; }
        public string PORTAFOLIO_ID { get; set; }
        public Nullable<bool> IS_COMPETITOR { get; set; }
        public Nullable<bool> INCLUDE_PRICE { get; set; }
    }
}
