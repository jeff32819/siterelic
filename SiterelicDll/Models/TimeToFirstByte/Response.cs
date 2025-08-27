namespace SiterelicDll.Models.TimeToFirstByte;

public class Response
{
    public long timestamp { get; set; }
    public string apiVersion { get; set; }
    public string apiStatus { get; set; }
    public int apiCode { get; set; }
    public Meta meta { get; set; }
    public int data { get; set; }

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