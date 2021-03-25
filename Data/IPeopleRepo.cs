using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public interface IPeopleRepo
    {
        bool SaveChanges();

        IEnumerable<People> GetAllPeoples();
        People GetPeopleById(int Id);

        void CreatePeople(People people);

        void UpdatePeople(People people);
    }
}
