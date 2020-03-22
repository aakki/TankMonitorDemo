using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TankMonitorDemo.Configuration;

namespace TankMonitorDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(TankMonitorDemoWebCoreModule))]
    public class TankMonitorDemoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TankMonitorDemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TankMonitorDemoWebHostModule).GetAssembly());
        }
    }
}
