using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrustBusinessLayer.Dtos
{
    public class OutletCreateDto
    {
        [Required]
        public string OutletName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string Landmark { get; set; }
        [Required]
        public int VolunteerAvailable { get; set; }
        [Required]
        public int PacketsCount { get; set; }
    }
}
