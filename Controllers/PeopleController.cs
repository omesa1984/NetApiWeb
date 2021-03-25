using AvaliacaoNetApiWeb.Data;
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

        public PeopleController(IPeopleRepo repository)
        {
            _repository = repository;
        }

        //GET api/peoples
        [HttpGet]
        public ActionResult<IEnumerable<People>> GetAllPeople()
        {
            var peopleItems = _repository.GetAllPeoples();

            return Ok(peopleItems);
        }

        //GET api/peoples/{id}
        [HttpGet("{id}")]
        public ActionResult<People> GetPeopleById(int Id)
        {
            var peopleItems = _repository.GetPeopleById(Id);

            return Ok(peopleItems);
        }
    }
}
