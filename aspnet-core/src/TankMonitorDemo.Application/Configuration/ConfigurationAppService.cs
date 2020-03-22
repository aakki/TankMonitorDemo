using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TankMonitorDemo.Configuration.Dto;

namespace TankMonitorDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TankMonitorDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
