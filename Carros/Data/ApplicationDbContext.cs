using Carros.Models;
using Microsoft.EntityFrameworkCore;

namespace Carros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
            {
            }

        public DbSet<Car> Cars {  get; set; }
    }
}
    