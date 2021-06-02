using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace authentication_and_authorization.Models
{
    public class dbcontext:DbContext
    {
        public dbcontext() : base("cs")
        {

        }
        public DbSet<user> users { get; set; }
        public DbSet<Role> Roles { get; set; }
      

    }
}