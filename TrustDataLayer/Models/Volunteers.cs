using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrustDataLayer.Models
{
    public class Volunteers
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public long Phone { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string OutletChoice { get; set; }
        public Outlets OutletName { get; set; }
    }
}
