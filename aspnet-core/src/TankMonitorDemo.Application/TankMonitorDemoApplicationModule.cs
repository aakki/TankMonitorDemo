using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TankMonitorDemo.Authorization;

namespace TankMonitorDemo
{
    [DependsOn(
        typeof(TankMonitorDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TankMonitorDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TankMonitorDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TankMonitorDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
