using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class Customer
    {
        int id_customer { get; set; }
        string name { get; set; }
        string identification { get; set; }
        string email { get; set; }
        string address { get; set; }
        int id_type_identification { get; set; }
        
    }
}