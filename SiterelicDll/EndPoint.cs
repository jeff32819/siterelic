using System.Diagnostics.CodeAnalysis;

namespace SiterelicDll
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public static class EndPoint
    {
        /// <summary>
        /// The DNSSEC API test if security extension is enabled on the domain.
        /// </summary>
        public static string DnsSecurity => "dnssec";

        /// <summary>
        /// The Mixed Content API checks whether a given website loads one or more static assets as mixed content.
        /// </summary>

        public static string MixedContent => "mixedcontent";

        /// <summary>
        /// The TTFB API measures how fast a web resource starts loading when connected. It can be thought of as a way to measure response times (in milliseconds), loosely speaking.
        /// </summary>
        public static string TimeToFirstByte => "ttfb";

        /// <summary>
        /// The TLS Scan API provides info about the supported TLS versions as well as the deployed certificate info for a given domain.
        /// </summary>
        public static string TlsScanner => "tlsscan";
        /// <summary>
        /// The Load Time API provides the total time (in milliseconds) it takes for an HTTP response to complete. This is often used to measure website performance and includes time taken for DNS lookup, waiting for the server to respond, data sent, data received, etc.
        /// https://siterelic.com/docs#load-time
        /// </summary>
        public static string LoadTime => "loadtime";
    }
}
