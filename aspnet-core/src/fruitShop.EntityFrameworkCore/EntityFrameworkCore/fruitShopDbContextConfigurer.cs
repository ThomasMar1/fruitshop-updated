using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace fruitShop.EntityFrameworkCore
{
    public static class fruitShopDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<fruitShopDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<fruitShopDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
