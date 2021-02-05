using AutoMapper;
using BusinessService.Dtos;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Profiles
{
    public class GothamCharityTrustProfile : Profile
    {
        public GothamCharityTrustProfile()
        {
            CreateMap<Admins, AdminReadDto>();
            CreateMap<AdminCreateDto, Admins>();
            CreateMap<AdminUpdateDto, Admins>();
            CreateMap<Admins, AdminUpdateDto>();

            CreateMap<Volunteers, VolunteerReadDto>();
            CreateMap<VolunteerCreateDto, Volunteers>();
            CreateMap<VolunteerUpdateDto, Volunteers>();
            CreateMap<Volunteers, VolunteerUpdateDto>();

            CreateMap<Outlets, OutletReadDto>();
            CreateMap<OutletCreateDto, Outlets>();
            CreateMap<OutletUpdateDto, Outlets>();
            CreateMap<Outlets, OutletUpdateDto>();
        }
       

            

            

    }
}
