using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryUser : IRepositoryUser
    {
        //Defino atributo
        private readonly AppContext _appContext;
        
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryUser(AppContext appContext)
        {
            _appContext = appContext;
        }
    }
}