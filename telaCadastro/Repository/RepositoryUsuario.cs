using Microsoft.Extensions.Configuration;
using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace telaCadastro.Repository
{
    public class RepositoryUsuario : IRepository
    {

        private IDbConnection _conecaoBD;

        public RepositoryUsuario()
        {
            _conecaoBD = new SqlConnection(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBcadastro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public List<Usuario> buscaToddos()
        {

            var consulta = "select * from usuario;";

            var listaUsuario = new List<Usuario>();

            listaUsuario = _conecaoBD.Query<Usuario>(consulta).ToList();

            return listaUsuario;
        }


    }
}
