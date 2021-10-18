using System;

namespace Produccion.App.Domain
{
    public class OcDetailsFkProduct
    {
        public int id { get; set; }
        public int id_purchanse_order { get; set; }
        public int id_product { get; set; }
        public int qty { get; set; }
    }
}