using Gurukula.System.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gurukula.System.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Organization> Organizations {get;set;}
        public DbSet<Institution> Institutions {get;set;}
        public DbSet<Adminstrator> Adminstrators {get;set;}
    }
}