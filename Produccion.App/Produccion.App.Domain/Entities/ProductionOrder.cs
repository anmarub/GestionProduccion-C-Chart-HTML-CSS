using System;
using System.Collections.Generic;

namespace Produccion.App.Domain.Entities
{
    public class ProductionOrder
    {
        int id_op { get; set; }
        string code_order { get; set; }
        string date_delivery { get; set; }
        string mod { get; set; }
        int id_status_op { get; set; }
        
    }
}