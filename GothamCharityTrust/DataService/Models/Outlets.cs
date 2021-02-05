using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataService.Models
{
    public class Outlets
    {
        [Key]
        public string outletname { get; set; }
        [Required]
        public string streetname { get; set; }
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
