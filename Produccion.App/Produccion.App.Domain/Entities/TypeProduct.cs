using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class TypeProduct
    {
        int id_type_product { get; set;}
        string code_product { get; set;}
        string name { get; set;}
    }
}