using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public interface IPhoneRepo
    {
        IEnumerable<Phone> GetAllPhones();
        Phone GetPhoneById(int Id);
    }
}
