using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using fruitShop.Configuration;
using fruitShop.Web;

namespace fruitShop.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class fruitShopDbContextFactory : IDesignTimeDbContextFactory<fruitShopDbContext>
    {
        public fruitShopDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<fruitShopDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            fruitShopDbContextConfigurer.Configure(builder, configuration.GetConnectionString(fruitShopConsts.ConnectionStringName));

            return new fruitShopDbContext(builder.Options);
        }
    }
}
