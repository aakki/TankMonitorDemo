using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TankMonitorDemo.Products
{
    //: FullAuditedEntity
    public class Product : Entity<int>
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ShortName { get; set; }

        [Required]
        public string ProductCode { get; set; }

        public bool IsActive { get; set; }
        public int Qty { get; set; }

    }
}
