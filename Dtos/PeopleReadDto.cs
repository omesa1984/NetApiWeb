using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Dtos
{
    public class PeopleReadDto
    {
        //public int Id { get; set; }

        public String Nome { get; set; }

        public String Cpf { get; set; }

        public String Rg { get; set; }

        public PhoneReadDto Phone { get; set; }

        //public int Phone_People_Id { get; set; }

        public AddressReadDto Address { get; set; }

        //public int Address_People_Id { get; set; }
    }
}
