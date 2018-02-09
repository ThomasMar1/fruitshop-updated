using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using fruitShop.Authorization.Roles;
using fruitShop.Authorization.Users;
using fruitShop.MultiTenancy;
using fruitShop.Domain;

namespace fruitShop.EntityFrameworkCore
{
    public class fruitShopDbContext : AbpZeroDbContext<Tenant, Role, User, fruitShopDbContext>
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplierFruit>().HasKey(sf => new { sf.supplierId, sf.fruitId });
        }

        /* Define a DbSet for each entity of the application */
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<staff> staffMembers { get; set; }
        public virtual DbSet<fruit> fruits { get; set; }
        public virtual DbSet<SupplierFruit> SupplierFruits { get; set; }



        public fruitShopDbContext(DbContextOptions<fruitShopDbContext> options)
            : base(options)
        {
        }



    }
}
