using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace TankMonitorDemo.Products.Dto
{
    public class ProductListDto : EntityDto
    {
        public string ProductName { get; set; }

        public string ShortName { get; set; }

        public string ProductCode { get; set; }

        public bool IsActive { get; set; }
        public int Qty { get; set; }
    }
}
