using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class PurchanseOrder
    {
        int id_oc { get; set; }
        string num_oc { get; set; }
        int id_customer { get; set; }
        int id_status_oc { get; set; }
        string date_delivery { get; set; }
    }
}