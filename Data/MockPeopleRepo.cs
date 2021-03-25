using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class MockPeopleRepo : IPeopleRepo
    {
        public void CreatePeople(People peop)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<People> GetAllPeoples()
        {
            var phone = new Phone { Id = 0, Tipo = "celular", Numero = "(21) 969710-949" };
            var address = new Address { Id = 0, Cep = "20251-540", Logradouro = "Rua Paraiso", Numero = "94", Complemento = "SB", Bairro = "Santa Teresa", Municipio = "Rio de Janeiro", Uf = "RJ" };

            var people = new List<People>()
            {
                new People { Id = 1, Nome = "Oslien", Cpf = "063.917.357-86", Rg = "G784596-V", Phone = phone, Phone_People_Id = 0, Address = address, Address_People_Id = 0 },
                new People { Id = 2, Nome = "Oslien", Cpf = "063.917.357-86", Rg = "G784596-V", Phone = phone, Phone_People_Id = 1, Address = address, Address_People_Id = 1 },
                new People { Id = 3, Nome = "Oslien", Cpf = "063.917.357-86", Rg = "G784596-V", Phone = phone, Phone_People_Id = 2, Address = address, Address_People_Id = 2 }
            };

            return people;
        }

        public People GetPeopleById(int Id)
        {
            var phone = new Phone { Id = 0, Tipo = "celular", Numero = "(21) 969710-949" };
            var address = new Address { Id = 0, Cep = "20251-540", Logradouro = "Rua Paraiso", Numero = "94", Complemento = "SB", Bairro = "Santa Teresa", Municipio = "Rio de Janeiro", Uf = "RJ" };

            return new People { Id = 0, Nome = "Oslien", Cpf = "063.917.357-86", Rg = "G784596-V", Phone = phone, Phone_People_Id = Id, Address = address, Address_People_Id = Id };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(People people)
        {
            throw new NotImplementedException();
        }
    }
}
