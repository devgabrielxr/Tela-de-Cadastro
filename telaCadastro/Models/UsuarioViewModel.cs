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
        public string NomeCompleto { get; set; }

        [Display(Name = "Data De Nascimento")]
        public DateTime DataNascimento { get; set; }

        public string Genero { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        public Telefone CelularUsuario { get; set; }
    }
}
