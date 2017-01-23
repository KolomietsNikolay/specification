using SpecificationWEB.Context;
using SpecificationWEB.Models;
using SpecificationWEB.Specification;
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

        public IEnumerable<User> GetAll(ISpecification<User> specification)
        {
            return this.context.Users.Where(specification.IsSatisfiedBy().Compile());
        }
    }
}