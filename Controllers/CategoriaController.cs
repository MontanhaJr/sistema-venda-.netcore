using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class CategoriaController : Controller
    {
        readonly IServicoAplicacaoCategoria ServicoAplicacaoCategoria;

        public CategoriaController(IServicoAplicacaoCategoria servicoAplicacaoCategoria)
        {
            ServicoAplicacaoCategoria = servicoAplicacaoCategoria;
        }

        public IActionResult Index()
        {
            return View(ServicoAplicacaoCategoria.Listagem());
        }

        //[HttpGet]
        //public IActionResult Cadastro(int? id)
        //{
        //    CategoriaViewModel viewModel = new CategoriaViewModel();

        //    if(id != null)
        //    {
        //        var entidade = mContext.Categoria.Where(x => x.Codigo == id).FirstOrDefault();
        //        viewModel.Codigo = entidade.Codigo;
        //        viewModel.Descricao = entidade.Descricao;
        //    }

        //    return View(viewModel);
        //}

        //[HttpPost]
        //public IActionResult Cadastro(CategoriaViewModel entidade)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        Categoria objCategoria = new Categoria()
        //        {
        //            Codigo = entidade.Codigo,
        //            Descricao = entidade.Descricao
        //        };

        //        if(entidade.Codigo == null)
        //        {
        //            mContext.Categoria.Add(objCategoria);
        //        }
        //        else
        //        {
        //            mContext.Categoria.Update(objCategoria);
        //        }

        //        mContext.SaveChanges();
        //    }
        //    else
        //    {
        //        return View(entidade);
        //    }

        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult Excluir(int id)
        //{
        //    var objCategoria = mContext.Categoria.Where(x => x.Codigo == id).FirstOrDefault();

        //    mContext.Remove(objCategoria);
        //    mContext.SaveChanges();
         
        //    return RedirectToAction("Index");
        //}
    }
}
