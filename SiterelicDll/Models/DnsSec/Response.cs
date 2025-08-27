namespace SiterelicDll.Models.DnsSec
{
    public class Response
    {
        public int apiCode { get; set; }
        public string apiStatus { get; set; } = "";
        public string apiVersion { get; set; } = "";
        public Data data { get; set; } = null!;
        public Meta meta { get; set; } = null!;
        public long timestamp { get; set; }
        public class Data
        {
            public bool isEnabled { get; set; }
        }

        public class Meta
        {
            public string url { get; set; } = "";
        }
    }
}
