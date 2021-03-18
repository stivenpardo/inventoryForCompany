namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration
{
    public class DbSettings
    {
        public string ConnectionString { get; set; }
        public void CopyFrom(DbSettings options) => ConnectionString = options.ConnectionString;
    }
}
