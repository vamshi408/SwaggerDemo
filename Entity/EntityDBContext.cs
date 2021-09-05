using Microsoft.EntityFrameworkCore;
using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDemo.Entity
{
    public class EntityDBContext :DbContext
    {
        public EntityDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> users { get; set; }
        //public DbSet<UserType> usertype { get; set; }
        public DbSet<Property> property { get; set; }
       // public DbSet<PropertyType> propertytype { get; set; }
        //public DbSet<InterestedCustomers> interestedcustomers { get; set; }
    }
}
