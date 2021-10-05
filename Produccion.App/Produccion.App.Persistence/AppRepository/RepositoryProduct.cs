using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryProduct : IRepositoryProduct
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryProduct(AppContext appContext)
        {
            _appContext = appContext;
        }

        Product IRepositoryProduct.AddProduct(Product product)
        {
            return null;
        }

        IEnumerable<Product> IRepositoryProduct.GetAllProduct()
        {
            return null;
        }

        Product IRepositoryProduct.GetProduct(int IdProduct)
        {
            return null;
        }

        Product IRepositoryProduct.UpdateProduct(Product product)
        {
            return null;
        }

        void IRepositoryProduct.DeleteProduct(int IdProduct)
        {
            
        }

    }
}