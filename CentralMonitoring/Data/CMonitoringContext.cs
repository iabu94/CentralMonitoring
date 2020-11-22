using CentralMonitoring.Models;
using MySql.Data.Entity;
using System.Data.Entity;

namespace CentralMonitoring.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CMonitoringContext : DbContext
    {
        public CMonitoringContext() : base(nameOrConnectionString: "DefaultConnection") { }
        public virtual DbSet<Strip> Strips { get; set; }
        public virtual DbSet<StripData> StripDatas { get; set; }
    }
}