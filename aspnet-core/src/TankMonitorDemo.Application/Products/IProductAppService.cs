using Abp.Application.Services;
using TankMonitorDemo.Products.Dto;

namespace TankMonitorDemo.Products
{
    public interface IProductAppService : IAsyncCrudAppService<ProductDto, int, PagedProductResultRequestDto, CreateProductDto, ProductDto>
    {
    }
}
