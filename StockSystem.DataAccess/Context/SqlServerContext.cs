using Microsoft.EntityFrameworkCore;
using StockSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess.Context
{
    public class SqlServerContext: DbContext
    {
        private readonly string connectionString = string.Empty;

        public DbSet<Product> Product { get; set; }
        public DbSet<Movement> Movement { get; set; }

        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }

        /*public SqlServerContext()
        {
            connectionString = @"Data Source = DESKTOP-8LGGJRU\SQLEXPRESS; Initial Catalog = StockSystem; Integrated Security = true; User Id=sa; Password=";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(c => new { c.productId });
            modelBuilder.Entity<Product>().Property(c => c.productId).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            modelBuilder.Entity<Movement>().HasKey(c => new { c.movementId });
            modelBuilder.Entity<Movement>().Property(c => c.movementId).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            base.OnModelCreating(modelBuilder);
        }
    }
}
