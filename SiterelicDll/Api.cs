using DnsSec = SiterelicDll.Models.DnsSec;
using MixedContent = SiterelicDll.Models.MixedContent;
using TimeToFirstByte = SiterelicDll.Models.TimeToFirstByte;
using TlsScanner = SiterelicDll.Models.TlsScanner;


namespace SiterelicDll;

public partial class Api(string domainName)
{
    public string DomainName { get; } = domainName;

    public async Task<DnsSec.Response> DnsSec()
    {
        return await CallProcess<DnsSec.Response>(EndPoint.DnsSecurity, new DnsSec.Request
        {
            url = DomainName
        });
    }

    public async Task<MixedContent.Response> MixedContent()
    {
        return await CallProcess<MixedContent.Response>(EndPoint.MixedContent, new MixedContent.Request
        {
            url = DomainName,
            followRedirect = true,
            proxyCountry = "us"
        });
    }

    public async Task<TimeToFirstByte.Response> TimeToFirstByte()
    {
        return await CallProcess<TimeToFirstByte.Response>(EndPoint.TimeToFirstByte, new TimeToFirstByte.Request
        {
            url = DomainName
        });
    }

    public async Task<TlsScanner.Response> TlsScanner()
    {
        return await CallProcess<TlsScanner.Response>(EndPoint.TlsScanner, new TlsScanner.Request
        {
            url = domainName
        });
    }
}