using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrustBusinessLayer.Dtos;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Profiles
{
    public class GothamTrustProfile : Profile
    {
        public GothamTrustProfile()
        {
            CreateMap<Admins, AdminReadDto>();
            CreateMap<AdminCreateDto, Admins>();
            CreateMap<AdminUpdateDto, Admins>();
            CreateMap<Admins, AdminUpdateDto>();

            CreateMap<Volunteers, VolunteerReadDto>();
            CreateMap<VolunteerCreateDto, Volunteers>();
            CreateMap<VolunteerUpdateDto, Volunteers>();
            CreateMap<Volunteers, VolunteerUpdateDto>();

            CreateMap<Foods, FoodReadDto>();
            CreateMap<FoodCreateDto, Foods>();
            CreateMap<FoodUpdateDto, Foods>();
            CreateMap<Foods, FoodUpdateDto>();

            CreateMap<Outlets, OutletReadDto>();
            CreateMap<OutletCreateDto, Outlets>();
            CreateMap<OutletUpdateDto, Outlets>();
            CreateMap<Outlets, OutletUpdateDto>();
        }
    }
}
