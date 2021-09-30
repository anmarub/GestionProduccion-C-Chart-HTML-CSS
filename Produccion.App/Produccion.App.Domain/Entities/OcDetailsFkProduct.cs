using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class OcDetailsFkProduct
    {
        int id { get; set; }
        int id_purchanse_order { get; set; }
        int id_product { get; set; }
        int qty { get; set; }
    }
}