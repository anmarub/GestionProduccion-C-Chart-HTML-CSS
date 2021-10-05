using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryOcDetailsFkProduct : IRepositoryOcDetailsFkProduct
    {
        private readonly AppContext _appContext;

        public RepositoryOcDetailsFkProduct(AppContext appContext)
        {
            _appContext = appContext;
        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.AddDetailOC(OcDetailsFkProduct DetailOC)
        {
            return null;
        }

        IEnumerable<OcDetailsFkProduct> IRepositoryOcDetailsFkProduct.GetAllDetailOC()
        {
            return null;
        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.GetDetailOC(int IdDetail)
        {
            return null;
        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.UpdateDetailOC(OcDetailsFkProduct DetailOC)
        {
            return null;
        }

        void IRepositoryOcDetailsFkProduct.DeleteDetailOC(int IdDetail)
        {

        }
    }
}