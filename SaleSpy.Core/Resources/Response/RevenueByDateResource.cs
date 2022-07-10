using System;

namespace SaleSpy.Core.Resources.Response
{
    public class RevenueByDateResource
    {
        public DateTime SoldOn { get; set; }
        public decimal Revenue { get; set; }
    }
}
