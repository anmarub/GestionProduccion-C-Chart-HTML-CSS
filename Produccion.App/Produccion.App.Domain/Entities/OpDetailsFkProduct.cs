using System;

namespace Produccion.App.Domain.Entities
{
    public class OpDetailsFkProduct
    {
        public int id { get; set; }
        public int id_production_order { get; set; }
        public int id_product { get; set; }
        public int qty_production { get; set; }
        
    }
}