using XIVLauncher.Common.Util;

namespace XIVLauncher.Common
{
    public enum ClientLanguage
    {
        Japanese,
        English,
        German,
        French,
        Korean
    }

    public static class ClientLanguageExtensions
    {
        public static string GetLangCode(this ClientLanguage language, bool forceNa = false)
        {
            switch (language)
            {
                case ClientLanguage.Japanese:
                    return "ja";

                case ClientLanguage.English when GameHelpers.IsRegionNorthAmerica() || forceNa:
                    return "en-us";

                case ClientLanguage.English:
                    return "en-gb";

                case ClientLanguage.German:
                    return "de";

                case ClientLanguage.French:
                    return "fr";

                case ClientLanguage.Korean:
                    return "ko";

                default:
                    return "en-gb";
            }
        }
    }
}