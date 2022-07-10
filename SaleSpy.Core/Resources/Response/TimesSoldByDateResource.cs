using System;

namespace SaleSpy.Core.Resources.Response
{
    public class TimesSoldByDateResource
    {
        public DateTime SoldOn { get; set; }
        public int TimesSold { get; set; }
    }
}
