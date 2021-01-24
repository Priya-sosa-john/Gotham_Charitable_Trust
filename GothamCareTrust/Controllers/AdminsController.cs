using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustBusinessLayer.Dtos;
using TrustBusinessLayer.Repository;
using TrustDataLayer.Models;

namespace GothamCareTrust.Controllers
{
    [Route("api/[admins]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly IVolunteerRepo _volunteer;
        private readonly IMapper _mapper;
        private readonly IOutletRepo _outlet;
        private readonly IAdminRepo _admin;
        private readonly object GetAdminsById;

        public AdminsController(IVolunteerRepo volunteer, IMapper mapper, IOutletRepo outlet, IAdminRepo admin)
        {
            _volunteer = volunteer;
            _mapper = mapper;
            _outlet = outlet;
            _admin = admin;
        }


        [Route("api/admins")]
        [HttpGet]
        public ActionResult<IEnumerable<Volunteers>> GetAllVolunteers()
        {
            var volunteersList = _volunteer.GetAllVolunteers();


            return Ok(_mapper.Map<IEnumerable<VolunteerReadDto>>(volunteersList));
        }

        [Route("api/admins/{Outlet}")]
        [HttpGet("{Outlet}", Name = "VolunteersByOutlet")]
        public ActionResult<Volunteers> VolunteersByOutlet(string Outlet)
        {
            var volunteerList = _volunteer.VolunteersByOutlet(Outlet);
            if (volunteerList != null)
            {
                return Ok(_mapper.Map<VolunteerReadDto>(volunteerList));
            }
            return NotFound();
        }

        [Route("api/admins/Outletdetails")]
        [HttpGet]
        public ActionResult<IEnumerable<Outlets>> GetAllOutletDetails()
        {
            var outletList = _outlet.GetAllOutletDetails();


            return Ok(_mapper.Map<IEnumerable<VolunteerReadDto>>(outletList));
        }

        [Route("api/admins/PostAdmin")]
        [HttpPost]

        public ActionResult<AdminReadDto> CreateAdmin(AdminCreateDto adminCreateDto)
        {
            var adminModel = _mapper.Map<Admins>(adminCreateDto);
            _admin.CreateAdmin(adminModel);
            _admin.SaveChanges();

            var AdminReadDto = _mapper.Map<AdminReadDto>(adminModel);

            return CreatedAtRoute(nameof(GetAdminsById), new { Id = AdminReadDto.ID }, AdminReadDto);
        }
    }
}
