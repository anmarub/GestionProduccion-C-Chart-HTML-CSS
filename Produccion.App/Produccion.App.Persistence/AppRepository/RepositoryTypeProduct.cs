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
            var NewtypeProduct = _appContext.TypeProduct.Add(typeProduct);
            _appContext.SaveChanges();
            return NewtypeProduct.Entity;
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
            var SearchtypeProduct = _appContext.TypeProduct.FirstOrDefault(i => i.id == typeProduct.id);
            if(SearchtypeProduct != null)
            {
                typeProduct.id = SearchtypeProduct.id;
                typeProduct.code_product = SearchtypeProduct.code_product;
                typeProduct.name = SearchtypeProduct.name;
            }
            return SearchtypeProduct;
        }

        void IRepositoryTypeProduct.DeleteTypeProduct(int idTypeProduct)
        {
            
        }

    }
}