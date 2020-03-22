using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace TankMonitorDemo.Products.Dto
{
    // : EntityDto<int>
    //[AutoMapFrom(typeof(Product))]

    [AutoMap(typeof(Product))]
    public class ProductDto : EntityDto
    {
        public string ProductName { get; set; }

        public string ShortName { get; set; }

        public string ProductCode { get; set; }

        public bool IsActive { get; set; }
        public int Qty { get; set; }
    }
}
