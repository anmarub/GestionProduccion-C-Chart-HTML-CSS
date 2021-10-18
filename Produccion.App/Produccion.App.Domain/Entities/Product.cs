using System;

namespace Produccion.App.Domain
{
    public class Product
    {
        public int id { get; set; }
        public string code_product { get; set; }
        public string name_product { get; set; }
        public int id_type_product { get; set; }
        public string date_expiration{ get; set;}
        public string date_manufacturing { get; set; }
        public int qty_available { get; set;}
        public int qty_production { get; set; }
        public int qty_order { get; set; }
        public string lote {get; set; }

    }
}