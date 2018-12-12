using System.Configuration;

namespace EPiServer.Commerce.Orders.Cloud.Client
{
    public class StorageSettings  
    {
        const string EndpointKey = "episerver:orderstore.cosmos.endpoint";
        const string AccountKeyKey = "episerver:orderstore.cosmos.accountkey";
        const string DatabaseNameKey = "episerver:orderstore.cosmos.databasename";
        const string ThroughputKey = "episerver:orderstore.cosmos.throughput";

        public string Endpoint => ConfigurationManager.AppSettings[EndpointKey];
        public string AccountKey => ConfigurationManager.AppSettings[AccountKeyKey];
        public string DatabaseName => ConfigurationManager.AppSettings[DatabaseNameKey];
        public int Throughput => int.Parse(ConfigurationManager.AppSettings[ThroughputKey]);

    }
}
