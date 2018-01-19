using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using fruitShop.Authorization.Roles;
using fruitShop.Authorization.Users;
using fruitShop.MultiTenancy;

namespace fruitShop.EntityFrameworkCore
{
    public class fruitShopDbContext : AbpZeroDbContext<Tenant, Role, User, fruitShopDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public fruitShopDbContext(DbContextOptions<fruitShopDbContext> options)
            : base(options)
        {
        }
    }
}
