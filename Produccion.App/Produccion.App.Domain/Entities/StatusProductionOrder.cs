using System;

namespace Produccion.App.Domain.Entities
{
    public class StatusProductionOrder
    {
        public int id_status_op { get; set; }
        public string code_status_op { get; set; }
        public string name { get; set; }
    }
}