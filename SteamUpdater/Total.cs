namespace SteamCoronaUpdater
{
    class Total
    {
        public int cases { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }

        public Total(int cases, int deaths, int recovered)
        {
            this.cases = cases;
            this.deaths = deaths;
            this.recovered = recovered;
        }
    }
}
