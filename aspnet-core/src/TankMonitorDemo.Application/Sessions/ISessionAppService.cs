using System.Threading.Tasks;
using Abp.Application.Services;
using TankMonitorDemo.Sessions.Dto;

namespace TankMonitorDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
