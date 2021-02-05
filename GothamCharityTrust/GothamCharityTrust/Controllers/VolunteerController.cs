using AutoMapper;
using BusinessService.Dtos;
using BusinessService.Repository;
using DataService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GothamCharityTrust.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private readonly IVolunteerRepository _volunteers;
        private readonly IMapper _mapper;

        public VolunteerController(IVolunteerRepository volunteers, IMapper mapper)
        {
            _volunteers = volunteers;
            _mapper = mapper;
        }
        // GET: api/volunteers
        [HttpGet]
        public ActionResult<IEnumerable<Volunteers>> GetAllVolunteers()
        {
            var volunteersList = _volunteers.GetAllVolunteers();
            return Ok(_mapper.Map<IEnumerable<VolunteerReadDto>>(volunteersList));
        }

        // GET api/volunteers/{id}
        [HttpGet("{id}")]
        public ActionResult<VolunteerReadDto> GetVolunteersById(int id)
        {
            var volunteersList = _volunteers.GetVolunteersById(id);
            if (volunteersList != null)
            {
                return Ok(_mapper.Map<AdminReadDto>(volunteersList));
            }
            return NotFound();

        }

        // POST api/volunteers
        [HttpPost]
        public ActionResult<VolunteerReadDto> CreateVolunteer(VolunteerCreateDto volunteerCreateDto)
        {
            var volunteerModel = _mapper.Map<Volunteers>(volunteerCreateDto);
            _volunteers.CreateVolunteer(volunteerModel);
            _volunteers.SaveChanges();
            var volunteerReadDto = _mapper.Map<VolunteerReadDto>(volunteerModel);
            return CreatedAtRoute(nameof(GetVolunteersById), new { id = volunteerReadDto.id }, volunteerReadDto);
        }

        // PUT api/<VolunteerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VolunteerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
