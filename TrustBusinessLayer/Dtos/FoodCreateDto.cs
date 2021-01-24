using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrustBusinessLayer.Dtos
{
    public class FoodCreateDto
    {
        [Required]
        public string Category { get; set; }

        [Required]
        public string OutletAssign { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
