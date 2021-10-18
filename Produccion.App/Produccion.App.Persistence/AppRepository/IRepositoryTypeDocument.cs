using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryTypeDocument
    {
        TypeDocument AddTypeDocument(TypeDocument typeDocument);
        IEnumerable<TypeDocument> GetAllTypeDocuments();
        TypeDocument GetTypeDocument(int idType);
        TypeDocument UpdateTypeDocumet(TypeDocument TypeDocument);
        void DeleteTypeDocument(int idType);         
    }
}