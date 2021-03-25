using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public interface IPeopleRepo
    {
        IEnumerable<People> GetAllPeoples();
        People GetPeopleById(int Id);
    }
}
