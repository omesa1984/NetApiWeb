using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Dtos
{
    public class AddressReadDto
    {
        public String Cep { get; set; }

        public String Logradouro { get; set; }

        public String Numero { get; set; }

        public String Complemento { get; set; }

        public String Bairro { get; set; }

        public String Municipio { get; set; }

        public String Uf { get; set; }
    }
}
