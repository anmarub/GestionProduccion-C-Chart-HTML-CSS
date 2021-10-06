using System;

namespace Produccion.App.Domain.Entities
{
    public class PurchanseOrder
    {
        public int id { get; set; }
        public string num_oc { get; set; }
        public int id_customer { get; set; }
        public int id_status_oc { get; set; }
        public string date_delivery { get; set; }
    }
}