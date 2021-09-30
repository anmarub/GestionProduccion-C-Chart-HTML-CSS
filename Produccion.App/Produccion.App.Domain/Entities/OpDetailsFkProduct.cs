using System;
using System.Collections.Generic;

namespace Produccion.App.Domain.Entities
{
    public class OpDetailsFkProduct
    {
        int id { get; set; }
        int id_production_order { get; set; }
        int id_product { get; set; }
        int qty_production { get; set; }
        
    }
}