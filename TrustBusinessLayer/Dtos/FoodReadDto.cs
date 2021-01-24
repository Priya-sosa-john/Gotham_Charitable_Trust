using System;
using System.Collections.Generic;
using System.Text;

namespace TrustBusinessLayer.Dtos
{
    public class FoodReadDto
    {
        public int ID { get; set; }

        public string Category { get; set; }

        public string OutletAssign { get; set; }

        public string Date { get; set; }
    }
}
