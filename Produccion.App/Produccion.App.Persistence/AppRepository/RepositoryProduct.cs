using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

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
            var Newproduct = _appContext.Product.Add(product);
            _appContext.SaveChanges();
            return Newproduct.Entity;
        }

        IEnumerable<Product> IRepositoryProduct.GetAllProduct()
        {
            return _appContext.Product;
        }

        Product IRepositoryProduct.GetProduct(int IdProduct)
        {
            return _appContext.Product.FirstOrDefault(i => i.id == IdProduct);
        }

        Product IRepositoryProduct.UpdateProduct(Product product)
        {
            var Searchproduct = _appContext.Product.FirstOrDefault(i => i.id == product.id);
            if(Searchproduct != null){
                product.id = Searchproduct.id;
                product.code_product = Searchproduct.code_product;
                product.name_product = Searchproduct.name_product;
                product.id_type_product = Searchproduct.id_type_product;
                product.date_expiration = Searchproduct.date_expiration;
                product.date_manufacturing = Searchproduct.date_manufacturing;
                product.qty_available = Searchproduct.qty_available;
                product.qty_production = Searchproduct.qty_production;
                product.qty_order = Searchproduct.qty_order;
                product.lote = Searchproduct.lote;

            }
            return Searchproduct;
        }

        void IRepositoryProduct.DeleteProduct(int IdProduct)
        {
            
        }

    }
}