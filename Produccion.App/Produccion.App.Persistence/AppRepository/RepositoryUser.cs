using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

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
            var NewUsers = _appContext.User.Add(users);
            _appContext.SaveChanges();
            return NewUsers.Entity;
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
            var SearchUsers = _appContext.User.FirstOrDefault(i => i.id == Users.id);
            if(SearchUsers != null)
            {
                Users.id = SearchUsers.id;
                Users.username = SearchUsers.username;
                Users.email = SearchUsers.email;
                Users.password = SearchUsers.password;
                Users.name = SearchUsers.name;
                Users.fullname = SearchUsers.fullname;
            }
            return SearchUsers;
        }
        void IRepositoryUser.DeleteUser(int idUser)
        {

        }

    }
}