﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrustBusinessLayer.Dtos
{
    public class AdminReadDto
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }
    }
}
