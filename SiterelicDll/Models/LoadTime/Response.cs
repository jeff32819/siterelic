namespace SiterelicDll.Models.LoadTime
{
    public class Response
    {
        public class Data
        {
            public int dns { get; set; }
            public int connect { get; set; }
            public int tls { get; set; }
            public int send { get; set; }
            public int wait { get; set; }
            public int total { get; set; }
        }
        public long timestamp { get; set; }
        public string apiVersion { get; set; }
        public string apiStatus { get; set; }
        public int apiCode { get; set; }
        public Meta meta { get; set; }
        public Data data { get; set; }
        public class Meta
        {
            public string url { get; set; }
            public bool followRedirect { get; set; }
            public string redirectedURL { get; set; }
            public Test test { get; set; }
        }
        public class Test
        {
            public string id { get; set; }
        }
    }
}
