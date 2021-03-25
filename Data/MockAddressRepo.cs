using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class MockAddressRepo : IAddressRepo
    {
        public IEnumerable<Address> GetAllAddress()
        {
            var address = new List<Address>()
            {
                new Address { Id = 0, Cep = "20251-540", Logradouro = "Rua Paraiso", Numero = "94", Complemento = "SB", Bairro = "Santa Teresa", Municipio = "Rio de Janeiro", Uf = "RJ" },
                new Address { Id = 1, Cep = "20031-004", Logradouro = "Av. Almirante Barroso", Numero = "81", Complemento = "32B13", Bairro = "Centro", Municipio = "Rio de Janeiro", Uf = "RJ" },
                new Address { Id = 2, Cep = "20251-550", Logradouro = "Paula Matos", Numero = "", Complemento = "", Bairro = "Santa Teresa", Municipio = "Rio de Janeiro", Uf = "RJ" }
            };

            return address;
        }
        public Address GetAddressById(int Id)
        {
            return new Address { Id = 0, Cep = "20251-540", Logradouro = "Rua Paraiso", Numero = "94", Complemento = "SB", Bairro = "Santa Teresa", Municipio = "Rio de Janeiro", Uf = "RJ" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void CreateAddress(Address add)
        {
            throw new NotImplementedException();
        }
    }
}
