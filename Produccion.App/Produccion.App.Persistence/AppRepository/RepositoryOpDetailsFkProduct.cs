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
            return null;
        }

        OpDetailsFkProduct IRepositoryOpDetailsFkProduct.GetDetailsOP(int idOpDetails)
        {
            return null;
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