namespace FestManager_Core
{
    public class FestManagerSettings
    {
        public static FestManagerSettings Default { get; set; }

        public string ConnectionString { get; set; }

        public bool PrintDirektverkaufTwice { get; set; }

        public int DirektverkaufPersonalId { get; set; }

        public int DirektverkaufAusgabestelleId { get; set; }

        public bool TableNumbers { get; set; }

        public bool PrintStornoOrders { get; set; }

        public string Organisation { get; set; }

        public bool GroupElementsBeforePrint { get; set; }

        public string StornoSymbol { get; set; }

        public string EinpackenSymbol { get; set; }

        public FestManagerSettings()
        {
            ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data\FestManager.mdb";
            DirektverkaufAusgabestelleId = -1;
            DirektverkaufPersonalId = 1;
            EinpackenSymbol = "";
            GroupElementsBeforePrint = true;
            Organisation = "Fest";
            PrintDirektverkaufTwice = false;
            PrintStornoOrders = true;
            StornoSymbol = "!!!";
            TableNumbers = true;
        }
    }
}
