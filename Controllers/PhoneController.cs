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
    [Route("api/phones")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneRepo _repository;
        private readonly IMapper _mapper;

        public PhoneController(IPhoneRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/phones
        [HttpGet]
        public ActionResult<IEnumerable<PhoneReadDto>> GetAllPhones()
        {
            var phoneItmes = _repository.GetAllPhones();

            return Ok(_mapper.Map<IEnumerable<PhoneReadDto>>(phoneItmes));
        }

        //GET api/phones/{id}
        [HttpGet("{id}")]
        public ActionResult<PhoneReadDto> GetPhoneById(int Id)
        {
            var phoneItems = _repository.GetPhoneById(Id);

            if(phoneItems != null)
            {
                return Ok(_mapper.Map<PhoneReadDto>(phoneItems));
            }

            return NotFound();
        }
    }
}
