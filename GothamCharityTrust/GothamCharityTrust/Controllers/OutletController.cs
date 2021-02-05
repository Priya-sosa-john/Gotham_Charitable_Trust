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
    public class OutletController : ControllerBase
    {
        private readonly IOutletRepository _outlets;
        private readonly IMapper _mapper;

        public OutletController(IOutletRepository outlets,
            IMapper mapper)
        {
            _outlets = outlets;
            _mapper = mapper;
                
        }
              
        // GET: api/outlets
        [HttpGet]
        public ActionResult<IEnumerable<Outlets>> GetAllOutletDetails()
        {
            var outletList = _outlets.GetAllOutletDetails();
            return Ok(_mapper.Map<IEnumerable<OutletReadDto>>(outletList));
        }

        // GET api/outlets/5
        [HttpGet("{outletname}")]
        public ActionResult<Outlets> GetOutletDetailsByName(string outletname)
        {
            var outletList = _outlets.GetOutletDetailsByName(outletname);
            if (outletList != null)
            {
                return Ok(_mapper.Map<OutletReadDto>(outletList));
            }
            return NotFound();
        }

        // POST api/outlets
        [HttpPost]
        public ActionResult<OutletReadDto> CreateOutlet(OutletCreateDto outletCreateDto)
        {
            var outletModel = _mapper.Map<Outlets>(outletCreateDto);
            _outlets.CreateOutlet(outletModel);
            _outlets.SaveChanges();
            var outletReadDto = _mapper.Map<OutletReadDto>(outletModel);
            return CreatedAtRoute(nameof(GetOutletDetailsByName), new { outletname = outletReadDto.outletname }, outletReadDto);
        }
        
            // PUT api/outlets
            [HttpPut("{outletname}")]
        public ActionResult UpdateOutlet(string outletname, OutletUpdateDto outletUpdateDto)
        {
            var outletModelFromRepo = _outlets.GetOutletDetailsByName(outletname);
            if (outletModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(outletUpdateDto, outletModelFromRepo);
            _outlets.UpdateOutlet(outletModelFromRepo);
            _outlets.SaveChanges();
            return NoContent();
        }

        // DELETE api/outlets
        [HttpDelete("{outletname}")]
        public ActionResult DeleteOutlet(string outletname)
        {
            var outletFromRepo = _outlets.GetOutletDetailsByName(outletname);
            if (outletFromRepo == null)
            {
                return NotFound();
            }
            _outlets.DeleteOutlet(outletFromRepo);
            _outlets.SaveChanges();
            return NoContent();

        }

       
    }
}
