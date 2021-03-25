using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public interface IPhoneRepo
    {
        bool SaveChanges();

        IEnumerable<Phone> GetAllPhones();
        Phone GetPhoneById(int Id);

        void CreatePhone(Phone phone);

        void UpdatePhone(Phone phone);
    }
}
