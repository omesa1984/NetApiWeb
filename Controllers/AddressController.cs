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
    [Route("api/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepo _repository;
        private readonly IMapper _mapper;

        public AddressController(IAddressRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/address
        [HttpGet]
        public ActionResult<IEnumerable<AddressReadDto>> GetAllAddress()
        {
            var addressItmes = _repository.GetAllAddress();

            return Ok(_mapper.Map<IEnumerable<AddressReadDto>>(addressItmes));
        }

        //GET api/address/{id}
        [HttpGet("{id}")]
        public ActionResult<AddressReadDto> GetAddressById(int Id)
        {
            var addressItems = _repository.GetAddressById(Id);

            if(addressItems != null)
            {
                return Ok(_mapper.Map<AddressReadDto>(addressItems));
            }

            return NotFound();
        }
    }
}
