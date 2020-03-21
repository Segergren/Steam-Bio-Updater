namespace SteamCoronaUpdater
{
    class CountryInfo
    {
        public string country { get; set; }
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int recovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }
        public int casesPerOneMillion { get; set; }

        public CountryInfo(string country, int cases, int todayCases, int deaths, int todayDeaths, int recovered, int active, int critical, int casesPerOneMillion)
        {
            this.country = country;
            this.cases = cases;
            this.todayCases = todayCases;
            this.deaths = deaths;
            this.todayDeaths = todayDeaths;
            this.recovered = recovered;
            this.active = active;
            this.critical = critical;
            this.casesPerOneMillion = casesPerOneMillion;
        }
    }
}
