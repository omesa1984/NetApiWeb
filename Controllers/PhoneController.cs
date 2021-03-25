using AvaliacaoNetApiWeb.Data;
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

        public PhoneController(IPhoneRepo repository)
        {
            _repository = repository;
        }

        //GET api/phones
        [HttpGet]
        public ActionResult<IEnumerable<Phone>> GetAllPhones()
        {
            var phoneItmes = _repository.GetAllPhones();

            return Ok(phoneItmes);
        }

        //GET api/phones/{id}
        [HttpGet("{id}")]
        public ActionResult<Phone> GetPhoneById(int Id)
        {
            var phoneItems = _repository.GetPhoneById(Id);

            return Ok(phoneItems);
        }
    }
}
