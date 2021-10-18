using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryOcDetailsFkProduct
    {
        OcDetailsFkProduct AddDetailOC(OcDetailsFkProduct DetailOC);
        IEnumerable<OcDetailsFkProduct> GetAllDetailOC();
        OcDetailsFkProduct GetDetailOC(int IdDetail);
        OcDetailsFkProduct UpdateDetailOC(OcDetailsFkProduct DetailOC);
        void DeleteDetailOC(int IdDetail);
    }
}