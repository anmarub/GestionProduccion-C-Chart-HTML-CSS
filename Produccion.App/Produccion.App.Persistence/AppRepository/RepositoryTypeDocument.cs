using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

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
            var NewTypeDocument = _appContext.TypeDocument.Add(TypeDocument);
            _appContext.SaveChanges();
            return NewTypeDocument.Entity;
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
            var SearchTypeDocument = _appContext.TypeDocument.FirstOrDefault(i => i.id == TypeDocument.id);
            if(SearchTypeDocument != null)
            {
                TypeDocument.id = SearchTypeDocument.id;
                TypeDocument.code = SearchTypeDocument.code;
                TypeDocument.name = SearchTypeDocument.name;
            }
            return SearchTypeDocument;
        }

        void IRepositoryTypeDocument.DeleteTypeDocument(int idTypeDocument)
        {
            
        }
    }
}