// See https://aka.ms/new-console-template for more information

using SiterelicDll;

Console.WriteLine("Hello, World!");


var api = new Api("jeff32819.com");
 // var dnssec = await api.DnsSec();
//var mixedContent = await api.MixedContent();
//var ttfb = await api.TimeToFirstByte();
//var tlsScanner = await api.TlsScanner();
var loadTime = await Api.LoadTime("jeff32819.com");


//Console.WriteLine(dnssec.data.isEnabled);


Console.WriteLine("done");



