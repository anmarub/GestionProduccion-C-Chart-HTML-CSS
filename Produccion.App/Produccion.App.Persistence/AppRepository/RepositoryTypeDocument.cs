using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryTypeDocument : IREpositoryTypeDocument
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryTypeDocument(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        TypeDocument IRepositoryTypeDocument.AddTypeDocument(TypeDocument TypeDocument)
        {
            
        }

        IEnumerable<TypeDocument> IRepositoryTypeDocument.GetAllTypeDocuments()   
        {

        }

        TypeDocument IRepositoryTypeDocument.GetTypeDocument(int idTypeDocument)
        {

        }

        TypeDocument IRepositoryTypeDocument.UpdateTypeDocumet(TypeDocument TypeDocument)
        {

        }

        void IRepositoryTypeDocument.DeleteTypeDocument(int idTypeDocument)
        {
            
        }
    }
}