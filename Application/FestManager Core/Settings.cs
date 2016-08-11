 // ReSharper disable once CheckNamespace
namespace FestManager_Core.Properties
{
    /**
     * This is just a helper to fix the DataSet Editor in Visual Studio
     */
    public class Settings
    {

        // ReSharper disable once InconsistentNaming
        public string connectionString { get; set; }

        public static Settings Default => new Settings() { connectionString =  FestManagerSettings.StaticConnectionString };
    }
}
