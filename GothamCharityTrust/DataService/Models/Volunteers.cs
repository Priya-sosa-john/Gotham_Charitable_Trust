using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataService.Models
{
    public class Volunteers
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public long phone { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string outletchoice { get; set; }
        public Outlets outletname { get; set; }
    }
}
