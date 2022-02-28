using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telaCadastro.Models;


namespace telaCadastro.Services
{
    public interface IServiceCadastro
    {
       void CadastrarUsuario(UsuarioViewModel usuarioCadastrar);
    }
}
