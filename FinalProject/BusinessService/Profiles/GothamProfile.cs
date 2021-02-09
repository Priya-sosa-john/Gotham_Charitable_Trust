using AutoMapper;
using BusinessService.Dtos;
using DataService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Profiles
{
    public class GothamProfile : Profile
    {
        public GothamProfile()
        {
            

            CreateMap<outlet, OutletReadDto>();
            CreateMap<OutletCreateDto, outlet>();
            CreateMap<OutletUpdateDto, outlet>();
            CreateMap<outlet, OutletUpdateDto>();

            
        }
    }
}
