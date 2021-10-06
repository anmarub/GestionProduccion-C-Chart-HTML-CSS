using System;

namespace Produccion.App.Domain.Entities
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string identification { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int id_type_identification { get; set; }
        
    }
}