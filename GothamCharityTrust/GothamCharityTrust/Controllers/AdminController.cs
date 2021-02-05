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
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _ad;
        private readonly IMapper _mapper;

        public AdminController(IAdminRepository ad, IMapper mapper)
        {
            _ad = ad;
            _mapper = mapper;
           
        }

        // GET: api/admins
        [HttpGet]
        public ActionResult<IEnumerable<Admins>>  GetAllAdmins()
        {
            var adminsList = _ad.GetAllAdmins();
            return Ok(_mapper.Map<IEnumerable<AdminReadDto>>(adminsList));


        }

        // GET api/admin/5
        [HttpGet("{id}")]
        public ActionResult<AdminReadDto> GetAdminsById(int id)
        {
            var adminsList = _ad.AdminsById(id);
            if (adminsList != null)
            {
                return Ok(_mapper.Map<AdminReadDto>(adminsList));
            }
            return NotFound();

        }
        
        // POST api/<AdminController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdminController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
    }
}
