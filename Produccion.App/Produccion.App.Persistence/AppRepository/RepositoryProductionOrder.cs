using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryProductionOrder : IRepositoryProductionOrder
    {
        //Defino atributo
        private readonly AppContext _appContext;
        
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryProductionOrder(AppContext appContext)
        {
            _appContext = appContext;
        }
    }
}