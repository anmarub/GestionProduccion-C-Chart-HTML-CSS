using System;
using System.Collections.Generic;

namespace Produccion.App.Domain.Entities
{
    public class StatusProductionOrder
    {
        int id_status_op { get; set; }
        string code_status_op { get; set; }
        string name { get; set; }
    }
}