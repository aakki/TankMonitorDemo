using Abp.Application.Services;
using TankMonitorDemo.MultiTenancy.Dto;

namespace TankMonitorDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

