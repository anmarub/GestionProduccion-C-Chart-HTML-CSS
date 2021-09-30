using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Domain.Entities
{
    public class User
    {
        int id_user {get;set;}
        string username {get;set;}
        string email {get;set;}
        string password {get;set;}
        string name {get;set;}
        string fullname {get;set;}
    }
}