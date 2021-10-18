using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public class RepositoryProduct : IRepositoryProduct
    {
        //Defino atributo
        private readonly AppDbContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryProduct(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            try{
                    var Newproduct = await _appContext.Product.AddAsync(product);
                    await _appContext.SaveChangesAsync();
                    return Newproduct.Entity;
            }catch{
                throw;
            }

        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _appContext.Product.ToListAsync();
        }

        public async Task<Product> GetProduct(int IdProduct)
        {
            var SearchProduct = await _appContext.Product.FirstOrDefaultAsync(c => c.id == IdProduct);
            return SearchProduct;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var Searchproduct = await _appContext.Product.FirstOrDefaultAsync(i => i.id == product.id);
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

                await _appContext.SaveChangesAsync();
            }
            return Searchproduct;
        }

        public async Task<Product> DeleteProduct(int IdProduct)
        {
            var SearchProduct = await _appContext.Product.FirstOrDefaultAsync(c => c.id == IdProduct);
            if (SearchProduct != null)
            {
                _appContext.Product.Remove(SearchProduct);
                await _appContext.SaveChangesAsync();
                return SearchProduct;
            }
            return null;
        }

    }
}