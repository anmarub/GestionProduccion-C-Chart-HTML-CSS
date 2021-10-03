using System;

namespace Produccion.App.Domain.Entities
{
    public class User
    {
        public int id_user {get;set;}
        public string username {get;set;}
        public string email {get;set;}
        public string password {get;set;}
        public string name {get;set;}
        public string fullname {get;set;}
    }
}