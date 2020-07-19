using halkhata.Context;
using halkhata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace halkhata.Services
{
    public class UserService
    {
        HalkhataDbContext halkhataDbContext = new HalkhataDbContext();

        public User Create(User user)
        {
            halkhataDbContext.Users.Add(user);
            halkhataDbContext.SaveChanges();
            return user;
        }

    }
}