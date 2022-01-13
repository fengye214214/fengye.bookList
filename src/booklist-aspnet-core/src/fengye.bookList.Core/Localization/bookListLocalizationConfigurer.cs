using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace fengye.bookList.Localization
{
    public static class bookListLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(bookListConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(bookListLocalizationConfigurer).GetAssembly(),
                        "fengye.bookList.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
