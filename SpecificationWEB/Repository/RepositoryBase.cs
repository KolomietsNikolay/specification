using SpecificationWEB.Context;
using SpecificationWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SpecificationWEB.Repository
{
    public class RepositoryBase
    {
        private SysytemUsersDbContext context;

        public RepositoryBase()
        {
            this.context = new SysytemUsersDbContext();
        }

        public IQueryable<User> GetAll()
        {
            return this.context.Users.ToList().AsQueryable();
        }
    }
}