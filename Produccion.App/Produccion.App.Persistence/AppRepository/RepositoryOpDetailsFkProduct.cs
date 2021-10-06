using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryOpDetailsFkProduct : IRepositoryOpDetailsFkProduct
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryOpDetailsFkProduct(AppContext appContext)
        {
            _appContext = appContext;
        }

        OpDetailsFkProduct IRepositoryOpDetailsFkProduct.AddDetailsOP(OpDetailsFkProduct OpDetails)
        {
            return null;
        }

        IEnumerable<OpDetailsFkProduct> IRepositoryOpDetailsFkProduct.GetAllDetailsOP()
        {
            return _appContext.OpDetailsFkProduct;
        }

        OpDetailsFkProduct IRepositoryOpDetailsFkProduct.GetDetailsOP(int idOpDetails)
        {
            return _appContext.OpDetailsFkProduct.FirstOrDefault(i => i.id == idOpDetails);
        }

        OpDetailsFkProduct IRepositoryOpDetailsFkProduct.UpdateDetailsOP(OpDetailsFkProduct OpDetails)
        {
            return null;
        }

        void IRepositoryOpDetailsFkProduct.DeleteDetailsOP(int idOpDetails)
        {

        }
    }
}