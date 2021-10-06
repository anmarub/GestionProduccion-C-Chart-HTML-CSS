using System;

namespace Produccion.App.Domain.Entities
{
    public class ProductionOrder
    {
        public int id { get; set; }
        public string code_order { get; set; }
        public string date_delivery { get; set; }
        public string mod { get; set; }
        public int id_status_op { get; set; }
    }
}