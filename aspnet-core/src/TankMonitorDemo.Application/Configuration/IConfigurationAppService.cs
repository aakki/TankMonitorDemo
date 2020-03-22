using System.Threading.Tasks;
using TankMonitorDemo.Configuration.Dto;

namespace TankMonitorDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
