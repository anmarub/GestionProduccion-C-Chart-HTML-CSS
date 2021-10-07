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
            var NewOpDetails = _appContext.OpDetailsFkProduct.Add(OpDetails);
            _appContext.SaveChanges();
            return NewOpDetails.Entity;

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
            var SearchOpDetails = _appContext.OpDetailsFkProduct.FirstOrDefault(i => i.id == OpDetails.id);
            if (SearchOpDetails != null)
            {
                OpDetails.id = SearchOpDetails.id;
                OpDetails.id_production_order = SearchOpDetails.id_production_order;
                OpDetails.id_product = SearchOpDetails.id_product;
                OpDetails.qty_production = SearchOpDetails.qty_production;
                _appContext.SaveChanges();
            }
            return SearchOpDetails;
        }

        void IRepositoryOpDetailsFkProduct.DeleteDetailsOP(int idOpDetails)
        {

        }
    }
}