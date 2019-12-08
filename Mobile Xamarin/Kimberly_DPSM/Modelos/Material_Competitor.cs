using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    class Material_Competitor
    {
        public string EAN { get; set; }
        public string DESCRIPTION { get; set; }
        public string CAT_ID { get; set; }
        public Nullable<int> COUNT { get; set; }
        public Nullable<int> MANUFACTURER_ID { get; set; }
        public string BRAND_ID { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
    }
}
