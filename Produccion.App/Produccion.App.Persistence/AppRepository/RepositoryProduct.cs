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

        }

        IEnumerable<Product> IRepositoryProduct.GetAllProduct()
        {

        }

        Product IRepositoryProduct.GetProduct(int IdProduct)
        {

        }

        Product IRepositoryProduct.UpdateProduct(int IdProduct)
        {

        }

        void IRepositoryProduct.DeleteProduct(int IdProduct)
        {
            
        }

    }
}