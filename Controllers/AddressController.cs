using AvaliacaoNetApiWeb.Data;
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

        public AddressController(IAddressRepo repository)
        {
            _repository = repository;
        }

        //GET api/address
        [HttpGet]
        public ActionResult<IEnumerable<Address>> GetAllAddress()
        {
            var addressItmes = _repository.GetAllAddress();

            return Ok(addressItmes);
        }

        //GET api/address/{id}
        [HttpGet("{id}")]
        public ActionResult<Address> GetAddressById(int Id)
        {
            var addressItems = _repository.GetAddressById(Id);

            return Ok(addressItems);
        }
    }
}
