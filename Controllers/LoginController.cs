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
        protected ApplicationDbContext mContext;
        protected IHttpContextAccessor HttpContextAccessor;

        public LoginController(ApplicationDbContext context, IHttpContextAccessor httpContext)
        {
            mContext = context;
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
                var autenticacao = mContext.Usuario.Where(x => 
                                x.Email == model.Email && 
                                x.Senha == Criptografia.GetMd5Hash(model.Senha))
                                .FirstOrDefault();

                if (autenticacao == null)
                {
                    ViewData["ErroLogin"] = "Email e/ou Senha incorretos";
                    return View(model);
                }
                else
                {
                    HttpContextAccessor.HttpContext.Session.SetInt32(Sessao.LOGADO, 1);
                    HttpContextAccessor.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, (int)autenticacao.Codigo);
                    HttpContextAccessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, autenticacao.Nome);
                    HttpContextAccessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, autenticacao.Email);

                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View(model);
            }

        }
    }
}
