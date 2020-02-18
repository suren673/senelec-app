using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Senelec.WebApp.Models;

namespace Senelec.WebApp.Data
{
    public class SenelecContext : DbContext
    {
        public SenelecContext (DbContextOptions<SenelecContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Senelec.WebApp.Models.Product> Product { get; set; }
    }
}
