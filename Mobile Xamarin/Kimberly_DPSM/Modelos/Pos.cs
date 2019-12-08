using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    class Pos
    {
        public int POS_ID { get; set; }
        public string COUNTRY { get; set; }
        public string POS_REGION { get; set; }
        public Nullable<int> FORMAT_ID { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<decimal> LATITUD { get; set; }
        public Nullable<decimal> LONGITUD { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
    }
}
