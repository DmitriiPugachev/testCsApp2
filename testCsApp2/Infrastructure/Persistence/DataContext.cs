using Microsoft.EntityFrameworkCore;
using TestCsApp.Domain.Entities;

namespace testCsApp2.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Item> Items { get; set; }
    }
}