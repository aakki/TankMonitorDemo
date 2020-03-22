using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TankMonitorDemo.Products.Dto
{
    //: EntityDto<int>
    [AutoMapTo(typeof(Product))]
    public class UpdateProductDto : CreateProductDto, IEntityDto
    {
        public int Id { get; set; }
        //public string ProductName { get; set; }

        //public string ShortName { get; set; }
        //public string ProductCode { get; set; }

        //public bool IsActive { get; set; }
        //public int Qty { get; set; }

    }
}
