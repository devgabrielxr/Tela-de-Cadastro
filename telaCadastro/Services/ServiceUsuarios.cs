using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telaCadastro.Repository;
using telaCadastro.Models;
using Models.Entidades.Enum;
using System.Globalization;

namespace telaCadastro.Services
{
    public class ServiceUsuarios : IServiceCadastro
    {
        private readonly IRepository repository;

        public ServiceUsuarios()
        {
            repository = new RepositoryUsuario();
        }

        public void CadastrarUsuario(UsuarioViewModel usuarioCadastrar)
        {
            var usuarioInsercao = new Usuario()
            {
                NomeCompleto = usuarioCadastrar.NomeCompleto,
               /* DataNascimento = usuarioCadastrar.DataNascimento, // a tratar pois pode gerar um possiver erro de conversao da tela pro banco*/
                CPF = usuarioCadastrar.CPF,
                Email = usuarioCadastrar.Email,
                Genero = usuarioCadastrar.Genero,
                RG = usuarioCadastrar.Genero,
               /* CelularUsuario = usuarioCadastrar.CelularUsuario,*/
                DataCadastro = DateTime.Now,
                Status = StatusUsuario.Ativo
            };

            repository.CadastrarUsuario(usuarioInsercao);

        }

    }
}
