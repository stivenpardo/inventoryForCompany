using System;

namespace InventoryFull.Infrastucture.Transversal.GenericMethods.Configuration
{
    public class HttpClientSettings
    {
        public string ServicePotocol { get; set; }
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string Context { get; set; }

        public void CopyFrom(HttpClientSettings settings)
        {
            ServicePotocol = settings.ServicePotocol;
            Port = settings.Port;
            Context = settings.Context;
            Hostname = settings.Hostname;
        }
        public Uri GetServiceUrl() => new UriBuilder
        {
            Host = Hostname,
            Port = Port,
            Path = Context,
            Scheme = ServicePotocol,
        }.Uri;
    }
}
