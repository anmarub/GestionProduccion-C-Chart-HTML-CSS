using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class TypeDocument
    {
        int id_document { get; set; }
        string code {get; set; }
        string name {get; set; }
        
    }
}