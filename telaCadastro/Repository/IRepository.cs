using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telaCadastro.Repository
{
    interface IRepository
    {
        List<Usuario> buscaToddos();
    }
}
