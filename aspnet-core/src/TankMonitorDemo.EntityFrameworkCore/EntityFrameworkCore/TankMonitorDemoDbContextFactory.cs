using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TankMonitorDemo.Configuration;
using TankMonitorDemo.Web;

namespace TankMonitorDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TankMonitorDemoDbContextFactory : IDesignTimeDbContextFactory<TankMonitorDemoDbContext>
    {
        public TankMonitorDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TankMonitorDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TankMonitorDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TankMonitorDemoConsts.ConnectionStringName));

            return new TankMonitorDemoDbContext(builder.Options);
        }
    }
}
