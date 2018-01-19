using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using fruitShop.Configuration;

namespace fruitShop.Web.Host.Startup
{
    [DependsOn(
       typeof(fruitShopWebCoreModule))]
    public class fruitShopWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public fruitShopWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(fruitShopWebHostModule).GetAssembly());
        }
    }
}
