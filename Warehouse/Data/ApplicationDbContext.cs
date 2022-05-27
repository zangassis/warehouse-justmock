using Microsoft.EntityFrameworkCore;
using Warehouse.Models;

namespace Warehouse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource = warehouse_db; Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seedData = Enumerable.Range(1, 11).Select(i => new Order
            {
                Id = i,
                Quantity = i * 10,
                ProductName = "ProductExample" + i,
            }).ToList();

            modelBuilder.Entity<Order>().HasData(
                seedData[0], seedData[1], seedData[2], seedData[3], seedData[4], seedData[5],
                seedData[6], seedData[7], seedData[8], seedData[9], seedData[10]);
        }
    }
}