using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using fruitShop.Authorization;

namespace fruitShop
{
    [DependsOn(
        typeof(fruitShopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class fruitShopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<fruitShopAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(fruitShopApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
