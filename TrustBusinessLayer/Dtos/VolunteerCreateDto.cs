﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrustBusinessLayer.Dtos
{
    public class VolunteerCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public long Phone { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string OutletChoice { get; set; }
    }
}
