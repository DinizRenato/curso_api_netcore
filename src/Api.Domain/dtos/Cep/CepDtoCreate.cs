using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.dtos.Cep
{
    public class CepDtoCreate
    {
        [Required(ErrorMessage = "CEP é obrigatório")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Número é obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Município é obrigatório")]
        public Guid MunicipioId { get; set; }

    }
}
