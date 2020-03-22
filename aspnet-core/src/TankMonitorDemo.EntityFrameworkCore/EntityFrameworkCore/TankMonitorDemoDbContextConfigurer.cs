using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TankMonitorDemo.EntityFrameworkCore
{
    public static class TankMonitorDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TankMonitorDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TankMonitorDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
