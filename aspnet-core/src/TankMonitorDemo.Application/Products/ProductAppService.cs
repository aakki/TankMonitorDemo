using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TankMonitorDemo.Authorization;
using TankMonitorDemo.Products.Dto;

namespace TankMonitorDemo.Products
{
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, int, PagedProductResultRequestDto, CreateProductDto, ProductDto>, IProductAppService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly ILogger<Product> _logger;
        private readonly IAbpSession _abpSession;
        public ProductAppService(IRepository<Product> productRepository,
              IAbpSession abpSession,
              ILogger<Product> logger
            ) : base(productRepository)
        {
            _abpSession = abpSession;
            _logger = logger;
        }
    }
}
