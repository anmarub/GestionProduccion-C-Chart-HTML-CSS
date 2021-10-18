using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Produccion.App.Domain
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