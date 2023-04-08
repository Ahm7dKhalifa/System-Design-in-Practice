using Domain.Core.Clients;
using Domain.Core.Products;
using Infrastructure.Database.SqlServer.ModelConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.SqlServer.EntityFrameworkCore
{
    public class DatabaseContext : DbContext
    {
        #region Products
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductViewer> ProductViewers { get; set; }
        public DbSet<ProductLike> ProductLikes { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductFileType> ProductFileTypes { get; set; }
        public DbSet<ProductFile> ProductFiles { get; set; }
        #endregion

        #region Clients
        public DbSet<Client> Clients { get; set; }
        #endregion
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configuration
            new ProductModelConfiguration().Configure(modelBuilder.Entity<Product>());
            #endregion

        }
        #endregion

    }
}
