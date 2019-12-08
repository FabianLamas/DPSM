using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    class Material_KCC
    {
        public string SKU { get; set; }
        public string DESCRIPTION { get; set; }
        public string CAT_ID { get; set; }
        public string EAN { get; set; }
        public Nullable<int> COUNT { get; set; }
        public string SUBBRAND_ID { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
    }
}
