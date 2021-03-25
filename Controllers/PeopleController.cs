using AutoMapper;
using AvaliacaoNetApiWeb.Data;
using AvaliacaoNetApiWeb.Dtos;
using AvaliacaoNetApiWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Controllers
{
    [Route("api/peoples")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepo _repository;
        private readonly IMapper _mapper;

        public PeopleController(IPeopleRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/peoples
        [HttpGet]
        public ActionResult<IEnumerable<PeopleReadDto>> GetAllPeople()
        {
            var peopleItems = _repository.GetAllPeoples();

            return Ok(_mapper.Map<IEnumerable<PeopleReadDto>>(peopleItems));
        }

        //GET api/peoples/{id}
        [HttpGet("{id}")]
        public ActionResult<PeopleReadDto> GetPeopleById(int Id)
        {
            var peopleItems = _repository.GetPeopleById(Id);

            if(peopleItems != null)
            {
                return Ok(_mapper.Map<PeopleReadDto>(peopleItems));
            }

            return NotFound();
        }
    }
}
