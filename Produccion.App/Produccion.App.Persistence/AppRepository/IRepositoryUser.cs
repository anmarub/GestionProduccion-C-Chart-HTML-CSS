using System;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryUser
    {
         User AddUser(User Users);
         IEnumerable<User> GetAllUser();
         User GetUser(int idUser);
         User UpdateUser(User Users);
         void DeleteUser(int idUser);
    }
}