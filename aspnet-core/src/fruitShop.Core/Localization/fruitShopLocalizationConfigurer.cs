using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace fruitShop.Localization
{
    public static class fruitShopLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(fruitShopConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(fruitShopLocalizationConfigurer).GetAssembly(),
                        "fruitShop.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
