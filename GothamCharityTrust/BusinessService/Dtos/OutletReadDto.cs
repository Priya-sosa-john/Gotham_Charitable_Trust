using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Dtos
{
    public class OutletReadDto
    {
        public string outletname { get; set; }
        public string streetName { get; set; }
        public string landmark { get; set; }
        public int volunteers { get; set; }
        public int packets { get; set; }
        public string foodtype { get; set; }
        public string date { get; set; }
    }
}
