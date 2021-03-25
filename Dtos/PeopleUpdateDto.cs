using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Dtos
{
    public class PeopleUpdateDto
    {
        [Required]
        public String Nome { get; set; }

        [Required]
        [MaxLength(14)]
        public String Cpf { get; set; }

        [Required]
        [MaxLength(10)]
        public String Rg { get; set; }

        public PhoneReadDto Phone { get; set; }

        //public int Phone_People_Id { get; set; }

        public AddressReadDto Address { get; set; }

        //public int Address_People_Id { get; set; }
    }
}
