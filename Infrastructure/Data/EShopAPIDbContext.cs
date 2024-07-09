using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationCore.Entity;

namespace Infrastructure.Data
{
    public class EShopAPIDbContext: DbContext
    {
        public EShopAPIDbContext(DbContextOptions<EShopAPIDbContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryVariation> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<VariationValue> Variations { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
