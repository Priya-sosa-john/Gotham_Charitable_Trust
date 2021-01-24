using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrustDataLayer.Models
{
    public class Outlets
    {
        [Key]
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
