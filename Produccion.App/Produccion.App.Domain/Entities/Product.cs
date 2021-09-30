using System;
using System.Collections.Generic;

namespace Produccion.App.Domain.Entities
{
    public class Product
    {
        int id_product { get; set; }
        string code_product { get; set; }
        string name_product { get; set; }
        int id_type_product { get; set; }
        string date_expiration{ get; set;}
        string date_manufacturing { get; set; }
        int qty_available { get; set;}
        int qty_production { get; set; }
        int qty_order { get; set; }
        string lote {get; set; }

    }
}