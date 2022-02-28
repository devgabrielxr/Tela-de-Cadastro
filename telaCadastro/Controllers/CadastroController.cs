using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using telaCadastro.Models;
using telaCadastro.Services;

namespace telaCadastro.Controllers
{
    public class CadastroController : Controller
    {
        public readonly IServiceCadastro _servicoCadastro;


        public CadastroController(IServiceCadastro service)
        {
            _servicoCadastro = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioViewModel usuario)
        {

            try
            {

                _servicoCadastro.CadastrarUsuario(usuario);


                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                // a implementar return RedirectToAction(nameof(Error), new { message = "Erro ao Cadastrar!" });
                return NotFound();
            }
        }

    }
}
