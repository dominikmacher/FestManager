using System.IO;
using System.Xml.Serialization;

namespace FestManager_Core
{
    [XmlRoot("Settings", Namespace = "http://festmanager.feuerwehr-karlstetten.at/")]
    public class FestManagerSettings
    {
        private string _connectionString;

        [XmlElement]
        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                _connectionString = value;
                StaticConnectionString = value;
            }
        }

        [XmlElement]
        public bool PrintDirektverkaufTwice { get; set; }

        [XmlElement]
        public int DirektverkaufPersonalId { get; set; }

        [XmlElement]
        public int DirektverkaufAusgabestelleId { get; set; }

        [XmlElement]
        public bool TableNumbers { get; set; }

        [XmlElement]
        public bool PrintStornoOrders { get; set; }

        [XmlElement]
        public string Organisation { get; set; }

        [XmlElement]
        public bool GroupElementsBeforePrint { get; set; }

        [XmlElement]
        public string StornoSymbol { get; set; }

        [XmlElement]
        public string EinpackenSymbol { get; set; }

        [XmlElement]
        public bool PrintTwice { get; set; }

        [XmlElement]
        public bool TableNumbersRequired { get; set; }

        [XmlElement]
        public static string StaticConnectionString { get; set; }

        public FestManagerSettings()
        {
            ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data\FestManager.mdb";
            DirektverkaufAusgabestelleId = 6;
            DirektverkaufPersonalId = 1;
            EinpackenSymbol = "";
            GroupElementsBeforePrint = true;
            Organisation = "Fest";
            PrintDirektverkaufTwice = false;
            PrintStornoOrders = true;
            StornoSymbol = "!!!";
            TableNumbers = true;
            PrintTwice = false;
            TableNumbersRequired = true;
        }

        public static FestManagerSettings Load(string fileName)
        {
            FestManagerSettings result = null;
            var serializer = new XmlSerializer(typeof(FestManagerSettings));
            using (var reader = new StreamReader(fileName))
            {
                result = (FestManagerSettings) serializer.Deserialize(reader);
            }

            return result;
        }

        public static void Save(string fileName, FestManagerSettings settings)
        {
            var serializer = new XmlSerializer(typeof(FestManagerSettings));
            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, settings);
            }
        }
    }
}
