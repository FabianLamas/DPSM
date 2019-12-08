using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Modelos
{
    [Table("DP_Audit")]
    public class DP_Audit
    {
        [PrimaryKey]
        public string SKU { get; set; }
        public string EAN { get; set; }
        public int POS_ID { get; set; }
        public string PORTAFOLIO_ID { get; set; }
        public bool? PRESENCE { get; set; }
        public decimal? PRICE { get; set; }
        public int? PROMO_ID { get; set; }
        public int? AUDIT_TIMESTAMP { get; set; }
        public decimal? LATITUD { get; set; }
        public decimal? LONGITUD { get; set; }
    }
}
