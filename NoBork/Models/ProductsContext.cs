using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class ProductsContext: DbContext
    {
        public DbSet<Blender> Blenders { get; set; }
        public DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        public DbSet<Grill> Grills { get; set; }
        public DbSet<Juicer> Juicers { get; set; }
        public DbSet<MeatGrinder> MeatGrinders { get; set; }
        public DbSet<Microwave> Microwaves { get; set; }
        public DbSet<Mixer> Mixers { get; set; }
        public DbSet<Scales> Scales { get; set; }
        public DbSet<SlowCooker> SlowCookers { get; set; }
        public DbSet<Toaster> Toasters { get; set; }

        public ProductsContext(DbContextOptions<ProductsContext> opt) :
            base(opt)
        {
//            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
