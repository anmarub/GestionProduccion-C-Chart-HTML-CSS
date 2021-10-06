using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryTypeDocument : IRepositoryTypeDocument
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
           return null; 
        }

        IEnumerable<TypeDocument> IRepositoryTypeDocument.GetAllTypeDocuments()   
        {
            return _appContext.TypeDocument;
        }

        TypeDocument IRepositoryTypeDocument.GetTypeDocument(int idTypeDocument)
        {
            return _appContext.TypeDocument.FirstOrDefault(i => i.id == idTypeDocument);
        }

        TypeDocument IRepositoryTypeDocument.UpdateTypeDocumet(TypeDocument TypeDocument)
        {
            return null;
        }

        void IRepositoryTypeDocument.DeleteTypeDocument(int idTypeDocument)
        {
            
        }
    }
}