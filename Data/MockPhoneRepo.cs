using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class MockPhoneRepo : IPhoneRepo
    {
        public void CreatePhone(Phone pho)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            var phones = new List<Phone>()
            {
                new Phone { Id = 0, Tipo = "celular", Numero = "(21) 969710-949"},
                new Phone { Id = 1, Tipo = "celular", Numero = "(21) 92000-3637"},
                new Phone { Id = 2, Tipo = "fixo", Numero = "(21) 5469-8754"}
            };

            return phones;
        }

        public Phone GetPhoneById(int Id)
        {
            return new Phone { Id = 0, Tipo = "celular", Numero = "(21) 969710-949" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdatePhone(Phone phone)
        {
            throw new NotImplementedException();
        }
    }
}
