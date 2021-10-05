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

        TypeProduct IRepositoryTypeDocument.AddTypeProduct(TypeProduct typeProduct)
        {

        }

        IEnumerable<TypeProduct> IRepositoryTypeProduct.GetAllTypeProduct()
        {

        }

        TypeProduct IRepositoryTypeDocumento.GetTypeProduct(int idTypeDocument)
        {

        }
        
        TypeProduct IRepositoryTypeDocument.UpdateTypeProduct(TypeProduct typeProduct)
        {

        }

        void IRepositoryTypeDocument.DeleteTypeProduct()
        {
            
        }

    }
}