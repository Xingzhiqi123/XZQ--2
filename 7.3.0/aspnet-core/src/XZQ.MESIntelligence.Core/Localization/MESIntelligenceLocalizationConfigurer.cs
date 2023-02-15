using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace XZQ.MESIntelligence.Localization
{
    public static class MESIntelligenceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MESIntelligenceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MESIntelligenceLocalizationConfigurer).GetAssembly(),
                        "XZQ.MESIntelligence.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
