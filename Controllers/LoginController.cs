using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Helpers;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class LoginController : Controller
    {
        protected IHttpContextAccessor HttpContextAccessor;
        readonly IServicoAplicacaoUsuario ServicoAplicacaoUsuario;

        public LoginController(IServicoAplicacaoUsuario servicoAplicacaoUsuario, IHttpContextAccessor httpContext)
        {
            ServicoAplicacaoUsuario = servicoAplicacaoUsuario;
            HttpContextAccessor = httpContext;
        }

        public IActionResult Index(int? id)
        {
            if (id != null && id == 0)
            {
                HttpContextAccessor.HttpContext.Session.Clear();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            ViewData["ErroLogin"] = string.Empty;
            if (ModelState.IsValid)
            {

                bool login = ServicoAplicacaoUsuario.ValidarLogin(model.Email, Criptografia.GetMd5Hash(model.Senha));
                var usuario = ServicoAplicacaoUsuario.RetornarDadosUsuario(model.Email, Criptografia.GetMd5Hash(model.Senha));

                if (login)
                {
                    HttpContextAccessor.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);
                    HttpContextAccessor.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, (int)usuario.Codigo);
                    HttpContextAccessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, usuario.Nome);
                    HttpContextAccessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, usuario.Email);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["ErroLogin"] = "Email e/ou Senha incorretos";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }

        }
    }
}
