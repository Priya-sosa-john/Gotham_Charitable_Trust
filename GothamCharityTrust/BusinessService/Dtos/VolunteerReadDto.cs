using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Dtos
{
    public class VolunteerReadDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
        public string date { get; set; }
        public string outletchoice { get; set; }
    }
}
