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

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.AddAddDetailOC(OcDetailsFkProduct DetailOC)
        {

        }

        IEnumerable<OcDetailsFkProduct> IRepositoryOcDetailsFkProduct.GetAllDetailOC(){

        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.GetDetailOC(int IdDetail)
        {

        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.UpdateDetailOC(OcDetailsFkProduct DetailOC)
        {

        }

        void IRepositoryOcDetailsFkProduct.DeleteDetailOC(int IdDetail)
        {

        }
    }
}