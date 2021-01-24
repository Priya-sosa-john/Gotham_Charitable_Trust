using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrustDataLayer.Models
{
    public class Foods
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string OutletAssign { get; set; }
        public Outlets OutletName { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
