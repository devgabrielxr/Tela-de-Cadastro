using System;
using System.Collections.Generic;
using Models.Entidades.Enum;

namespace Models.Entidades
{
    class Usuario
    {

        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Genero { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public StatusUsuario Status { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public List<Endereco> EnderecoUsuario { get; set; }

        public Usuario()
        {
            EnderecoUsuario = new List<Endereco>();
        }

        public void AdicionarEndereco(Endereco enderecoAdicionar)
        {
            EnderecoUsuario.Add(enderecoAdicionar);
        }
    }
}
