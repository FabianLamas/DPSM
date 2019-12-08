using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    class Portafolio
    {
        public string PORTAFOLIO_ID { get; set; }
        public int POS_ID { get; set; }
        public string MERCHAN_ID { get; set; }
        public string COUNTRY { get; set; }
        public Nullable<int> MONTH { get; set; }
        public string VISIT_DATE { get; set; }
    }
}
