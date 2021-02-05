using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessService.Dtos
{
    public class OutletCreateDto
    {
        [Required]
        public string outletname { get; set; }
        [Required]
        public string streetName { get; set; }
        [Required]
        public string landmark { get; set; }
        [Required]
        public int volunteers { get; set; }
        [Required]
        public int packets { get; set; }
        [Required]
        public string foodtype { get; set; }
        [Required]
        public string date { get; set; }
    }
}
