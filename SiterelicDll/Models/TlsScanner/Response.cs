namespace SiterelicDll.Models.TlsScanner
{
    public class Response
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Certificate
        {
            public string commonName { get; set; }
            public string subjectAltName { get; set; }
            public Issuer issuer { get; set; }
            public string expiry { get; set; }
        }

        public class Data
        {
            public Protocols protocols { get; set; }
            public Certificate certificate { get; set; }
        }

        public class Issuer
        {
            public string country { get; set; }
            public string organization { get; set; }
            public string commonName { get; set; }
        }

        public class Meta
        {
            public string url { get; set; }
            public Test test { get; set; }
        }
        public class Test
        {
            public string id { get; set; }
        }
        public class Protocols
        {
            public bool tls10 { get; set; }
            public bool tls11 { get; set; }
            public bool tls12 { get; set; }
            public bool tls13 { get; set; }
        }
        public long timestamp { get; set; }
        public string apiVersion { get; set; }
        public string apiStatus { get; set; }
        public int apiCode { get; set; }
        public Meta meta { get; set; }
        public Data data { get; set; }
    }
}
