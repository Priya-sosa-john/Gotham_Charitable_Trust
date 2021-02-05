using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessService.Dtos
{
    public class VolunteerCreateDto
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public long phone { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string outletchoice { get; set; }
    }
}
