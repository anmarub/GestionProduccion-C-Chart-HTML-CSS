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

        }

        IEnumerable<OpDetailsFkProduct> IRepositoryOpDetailsFkProduct.GetAllDetailsOP()
        {

        }

        OpDetailsFkProduct IRepositoryOpDetailsFkProduct.GetDetailsOP(int idOpDetails)
        {

        }

        OpDetailsFkProduct IRepositoryOpDetailsFkProduct.UpdateDetailsOP(OpDetailsFkProduct OpDetails)
        {

        }

        void IRepositoryOpDetailsFkProduct.DeleteDetailsOP(int idOpDetails)
        {

        }
    }
}