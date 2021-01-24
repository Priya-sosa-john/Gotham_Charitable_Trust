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
    [Route("api/[volunteers]")]
    [ApiController]
    public class VolunteersController : ControllerBase
    {
        private readonly IAdminRepo _admin;
        private readonly IMapper _mapper;
        private readonly IOutletRepo _outlet;
        private readonly IVolunteerRepo _volunteer;
        private readonly object VolunteersByOutlet;

        public VolunteersController(IAdminRepo admin, IMapper mapper, IOutletRepo outlet, IVolunteerRepo volunteer)
        {
            _admin = admin;
            _mapper = mapper;
            _outlet = outlet;
            _volunteer = volunteer;
        }
        // GET: api/volunteers
        [HttpGet]
        public ActionResult<IEnumerable<Admins>> GetAllAdmins()
        {
            var adminsList = _admin.GetAllAdmins();

            return Ok(_mapper.Map<IEnumerable<AdminReadDto>>(adminsList));
        }

        // GET api/volunteers/{id}
        [HttpGet("{id}", Name = "GetAdminsById")]
        public ActionResult<AdminReadDto> GetAdminsById(int ID)
        {
            var adminsList = _admin.AdminsById(ID);
            if (adminsList != null)
            {
                return Ok(_mapper.Map<AdminReadDto>(adminsList));
            }
            return NotFound();
        }

        [Route("api/volunteers/Outletdetails")]
        [HttpGet]
        public ActionResult<IEnumerable<Outlets>> GetAllOutletDetails()
        {
            var outletList = _outlet.GetAllOutletDetails();


            return Ok(_mapper.Map<IEnumerable<VolunteerReadDto>>(outletList));
        }

        [Route("api/volunteers/Postvolunteer")]
        [HttpPost]

        public ActionResult<VolunteerReadDto> CreateVolunteer(VolunteerCreateDto volunteerCreateDto)
        {
            var volunteerModel = _mapper.Map<Volunteers>(volunteerCreateDto);
            _volunteer.CreateVolunteer(volunteerModel);
            _volunteer.SaveChanges();

            var VolunteerReadDto = _mapper.Map<AdminReadDto>(volunteerModel);

            return CreatedAtRoute(nameof(VolunteersByOutlet), new { Id = VolunteerReadDto.ID }, VolunteerReadDto);
        }

        // POST api/<VolunteersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VolunteersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VolunteersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
