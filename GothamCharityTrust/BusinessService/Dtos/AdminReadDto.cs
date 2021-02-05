using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Dtos
{
    public class AdminReadDto
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
