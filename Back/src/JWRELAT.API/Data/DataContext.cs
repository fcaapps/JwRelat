using JWRELAT.API.Model;
using Microsoft.EntityFrameworkCore;

namespace JWRELAT.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Publicador> Publicadores { get; set; }
    }
}