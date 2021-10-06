using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.CompilerServices;

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

        User IRepositoryUser.AddUser(User users)
        {
            return null;
        }

        IEnumerable<User> IRepositoryUser.GetAllUser()
        {
            return _appContext.User;
        }
        User IRepositoryUser.GetUser(int idUser)
        {
            return _appContext.User.FirstOrDefault(i => i.id == idUser);
        }

        User IRepositoryUser.UpdateUser(User Users)
        {
            return null;
        }
        void IRepositoryUser.DeleteUser(int idUser)
        {

        }

    }
}