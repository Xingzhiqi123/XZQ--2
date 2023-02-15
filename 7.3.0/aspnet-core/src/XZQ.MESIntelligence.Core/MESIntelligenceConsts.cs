using XZQ.MESIntelligence.Debugging;

namespace XZQ.MESIntelligence
{
    public class MESIntelligenceConsts
    {
        public const string LocalizationSourceName = "MESIntelligence";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8eb2c0a4990d40d6bd604ca3961df4ef";
    }
}
