namespace Ombi.Api.Sonarr.Models.V3
{
    public class ReleaseProfiles
    {
        public string name { get; set; }
        public bool upgradeAllowed { get; set; }
        public Cutoff cutoff { get; set; }
        public Releases[] releases { get; set; }
        public int id { get; set; }
    }

    public class Releases
    {
        public Release releases { get; set; }
        public bool allowed { get; set; }
    }

    public class Release
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}