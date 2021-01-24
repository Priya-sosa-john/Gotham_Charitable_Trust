using System;
using System.Collections.Generic;
using System.Text;

namespace TrustBusinessLayer.Dtos
{
    public class OutletReadDto
    {
        public string OutletName { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }

        public int VolunteerAvailable { get; set; }

        public int PacketsCount { get; set; }
    }
}
