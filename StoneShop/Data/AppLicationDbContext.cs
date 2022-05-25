using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoneShop.Data
{
    public class AppLicationDbContext : IdentityDbContext
    {
        public AppLicationDbContext(DbContextOptions<AppLicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
