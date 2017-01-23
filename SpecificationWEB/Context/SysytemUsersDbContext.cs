using SpecificationWEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpecificationWEB.Context
{
    public class SysytemUsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<GroupUsers> Groups { get; set; }

        public SysytemUsersDbContext():base("DefaultConnection")
        { }
    }
}