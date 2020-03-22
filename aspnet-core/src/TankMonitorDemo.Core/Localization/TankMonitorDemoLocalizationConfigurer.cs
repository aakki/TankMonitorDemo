using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TankMonitorDemo.Localization
{
    public static class TankMonitorDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TankMonitorDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TankMonitorDemoLocalizationConfigurer).GetAssembly(),
                        "TankMonitorDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
