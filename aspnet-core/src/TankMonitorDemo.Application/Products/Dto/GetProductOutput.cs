using System;
using System.Collections.Generic;
using System.Text;

namespace TankMonitorDemo.Products.Dto
{
    public class GetProductOutput
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ShortName { get; set; }
        public string ProductCode { get; set; }

        public bool IsActive { get; set; }
        public int Qty { get; set; }

    }
}
