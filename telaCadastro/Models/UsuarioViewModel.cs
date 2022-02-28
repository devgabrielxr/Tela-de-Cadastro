using Models.Entidades;
using Models.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace telaCadastro.Models
{
    public class UsuarioViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} Obrigatorio!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} Tamanho maximo Entre {2} e {1} caracteres")]
        public string NomeCompleto { get; set; } 

        [Display(Name = "Data De Nascimento")]
        [Required(ErrorMessage = "{0} Obrigatorio!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; } 

        public string Genero { get; set; }

        [Required(ErrorMessage = "{0} Obrigatorio!")]
        [StringLength(11,MinimumLength = 11, ErrorMessage = "Tamanho para {0} tem que ter {1} digitos")]
        public string CPF { get; set; } 

        [Required(ErrorMessage = "{0} Obrigatorio!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} Tamanho maximo Entre {2} e {1} caracteres")]
        public string RG { get; set; } 

        [Required(ErrorMessage = "{0} Obrigatorio!")]
        [EmailAddress(ErrorMessage = "Entre com um email valido.")]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 

        public string NumeroCelular { get; set; }

        /* enum tipo celular */
    }
}
