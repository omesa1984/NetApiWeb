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
        [HttpGet("{id}", Name = "GetPhoneById")]
        public ActionResult<PhoneReadDto> GetPhoneById(int Id)
        {
            var phoneItems = _repository.GetPhoneById(Id);

            if(phoneItems != null)
            {
                return Ok(_mapper.Map<PhoneReadDto>(phoneItems));
            }

            return NotFound();
        }

        //POST api/phones
        [HttpPost]
        public ActionResult<PhoneReadDto> CreatePhone(PhoneCreateDto phoCreateDto)
        {
            var phone = _mapper.Map<Phone>(phoCreateDto);

            _repository.CreatePhone(phone);
            _repository.SaveChanges();

            var phoReadDto = _mapper.Map<PhoneReadDto>(phone);

            return CreatedAtRoute(nameof(GetPhoneById), new { Id = phoReadDto.Id }, phoReadDto);

        }

        //PUT api/phones/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePhone(int Id, PhoneUpdateDto phoneUpdateDto)
        {
            var phone = _repository.GetPhoneById(Id);

            if (phone == null)
                return NotFound();

             _mapper.Map(phoneUpdateDto, phone);

             _repository.UpdatePhone(phone);

             _repository.SaveChanges();

             return NoContent();
            
        }

    }
}
