using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Dtos
{
    public class AddressUpdateDto
    {
        [Required]
        [MaxLength(10)]
        public String Cep { get; set; }

        [Required]
        public String Logradouro { get; set; }

        [MaxLength(10)]
        public String Numero { get; set; }

        [MaxLength(10)]
        public String Complemento { get; set; }

        [Required]
        public String Bairro { get; set; }

        [Required]
        public String Municipio { get; set; }

        [Required]
        [MaxLength(2)]
        public String Uf { get; set; }
    }
}
