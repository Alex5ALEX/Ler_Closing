using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WarehouseClosingServer.Configurations;
using WarehouseClosingServer.Models;

namespace WarehouseClosingServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers {  get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<OrderCompaund> OrderCompaunds { get; set; }

        public DbSet<Product> Products { get; set; }   

        public DbSet<SupplyCompaund> SupplyCompaunds { get; set; }

        public DbSet<Supply> Supplies { get; set; }

        public DbSet<Provider> Providers { get; set; }




        //настройка строки подключения
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.EnableSensitiveDataLogging();
            var connectionString = "server=localhost;port=3306;database=WarehouseClosing;user id=root;password=BuildSQLData;";

            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderCompaundConfiguration());
            modelBuilder.ApplyConfiguration(new SupplyCompaundConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
