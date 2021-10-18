using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryOpDetailsFkProduct
    {
        OpDetailsFkProduct AddDetailsOP(OpDetailsFkProduct DetailOP);
        IEnumerable<OpDetailsFkProduct> GetAllDetailsOP();
        OpDetailsFkProduct GetDetailsOP(int IdDetail);
        OpDetailsFkProduct UpdateDetailsOP(OpDetailsFkProduct DetailOP);
        void DeleteDetailsOP(int IdDetail);
    }
}