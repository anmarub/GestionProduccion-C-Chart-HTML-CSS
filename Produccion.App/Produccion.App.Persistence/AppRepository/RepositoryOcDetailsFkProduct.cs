using System.Collections.Generic;
using System;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryOcDetailsFkProduct : IRepositoryOcDetailsFkProduct
    {
        private readonly AppContext _appContext;

        public RepositoryOcDetailsFkProduct(AppContext appContext)
        {
            _appContext = appContext;
        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.AddDetailOC(OcDetailsFkProduct DetailOC)
        {
            var NewDetail = _appContext.OcDetailsFkProduct.Add(DetailOC);
            _appContext.SaveChanges();
            return NewDetail.Entity;
        }

        IEnumerable<OcDetailsFkProduct> IRepositoryOcDetailsFkProduct.GetAllDetailOC()
        {
            return _appContext.OcDetailsFkProduct;
        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.GetDetailOC(int IdDetail)
        {
            return _appContext.OcDetailsFkProduct.FirstOrDefault(i => i.id == IdDetail);
        }

        OcDetailsFkProduct IRepositoryOcDetailsFkProduct.UpdateDetailOC(OcDetailsFkProduct DetailOC)
        {
            var SearchDetailOC = _appContext.OcDetailsFkProduct.FirstOrDefault(i => i.id == DetailOC.id);
            if (SearchDetailOC != null)
            {
                SearchDetailOC.id = DetailOC.id;
                SearchDetailOC.id_purchanse_order = DetailOC.id_purchanse_order;
                SearchDetailOC.id_product = DetailOC.id_product;
                SearchDetailOC.qty = DetailOC.qty;
                _appContext.SaveChanges();
            }
            return SearchDetailOC;
        }

        void IRepositoryOcDetailsFkProduct.DeleteDetailOC(int IdDetail)
        {
            var SearchDetailOC = _appContext.OcDetailsFkProduct.FirstOrDefault(i => i.id == IdDetail);
            if(SearchDetailOC == null)
            {
                return;
            }else{
                _appContext.OcDetailsFkProduct.Remove(SearchDetailOC);
                _appContext.SaveChanges();
            }
        }
    }
}