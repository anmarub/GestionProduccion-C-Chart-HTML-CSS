using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class StatusProductionOrder
    {
        int id_status_op { get; set; }
        string code_status_op { get; set; }
        string name { get; set; }
    }
}