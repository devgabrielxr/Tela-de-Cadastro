using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telaCadastro.Repository;

namespace telaCadastro.Services
{
    public class ServiceUsuarios : IServiceCadastro
    {
        private readonly IRepository repository;

        public ServiceUsuarios()
        {
            repository = new RepositoryUsuario();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            repository.buscaToddos();           
        }
    }
}
