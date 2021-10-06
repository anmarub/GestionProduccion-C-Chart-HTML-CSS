using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryTypeProduct : IRepositoryTypeProduct
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryTypeProduct(AppContext appContext)
        {
            _appContext = appContext;
        }

        TypeProduct IRepositoryTypeProduct.AddTypeProduct(TypeProduct typeProduct)
        {
            return null;
        }

        IEnumerable<TypeProduct> IRepositoryTypeProduct.GetAllTypeProduct()
        {
            return _appContext.TypeProduct;
        }

        TypeProduct IRepositoryTypeProduct.GetTypeProduct(int idTypeProduct)
        {
            return _appContext.TypeProduct.FirstOrDefault(i => i.id == idTypeProduct);
        }
        
        TypeProduct IRepositoryTypeProduct.UpdateTypeProduct(TypeProduct typeProduct)
        {
            return null;
        }

        void IRepositoryTypeProduct.DeleteTypeProduct(int idTypeProduct)
        {
            
        }

    }
}