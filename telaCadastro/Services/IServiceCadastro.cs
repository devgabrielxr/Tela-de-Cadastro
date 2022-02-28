using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Entidades;


namespace telaCadastro.Services
{
    public interface IServiceCadastro
    {
       void CadastrarUsuario(Usuario usuario);
    }
}
